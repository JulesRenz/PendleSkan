using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Globalization;
using System.Xml.Serialization;
using System.Threading;

namespace PendleSkan
{
    public partial class Form1 : Form
    {
        List<BackgroundWorker> workers = new List<BackgroundWorker>();
        public GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
        public GMap.NET.WindowsForms.GMapOverlay prev_markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
        public GMap.NET.WindowsForms.GMapOverlay polygons = new GMap.NET.WindowsForms.GMapOverlay("polygons");

        public ConfigResults resCfg = new ConfigResults();
        ProgConfig progCfg = new ProgConfig();

        Mutex QueueMutex = new Mutex();

        System.Windows.Forms.Timer heatmapTimer = new System.Windows.Forms.Timer();
        public Form1() {
            InitializeComponent();       
            progressBar1.Hide();

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            gMapControl1.ShowCenter = true;

            
            gMapControl1.Overlays.Add(prev_markers);
            gMapControl1.Overlays.Add(polygons);
            gMapControl1.Overlays.Add(markers);

            heatmapTimer.Interval = 5000;
            heatmapTimer.Tick += heatmapTimer_Tick;

            progCfg = loadConfigIfPresent();

            if (progCfg.apiKey == "") {
                DialogAddApiKey diag = new DialogAddApiKey();
                DialogResult res = diag.ShowDialog();
                if (res == System.Windows.Forms.DialogResult.OK) {
                    this.progCfg.apiKey = diag.apiKey;
                }
            }

            textBoxStartLat.Text = progCfg.centerPos.Lat.ToString();
            textBoxStartLong.Text = progCfg.centerPos.Lng.ToString();

            gMapControl1.Position = new GMap.NET.PointLatLng(
                Convert.ToDouble(textBoxStartLat.Text, CultureInfo.InvariantCulture),
                Convert.ToDouble(textBoxStartLong.Text, CultureInfo.InvariantCulture));

            numericUpDown_ValueChanged(null, null);
        }

        private ProgConfig loadConfigIfPresent() {
            XmlSerializer ser = new XmlSerializer(typeof(ProgConfig));

            string cfgFile = Application.StartupPath + "\\config.xml";
            ProgConfig cfg = new ProgConfig();

            if (File.Exists(cfgFile)) {
                FileStream fs = new FileStream(cfgFile, FileMode.Open, FileAccess.Read);
                cfg = (ProgConfig)ser.Deserialize(fs);

                fs.Flush();
                fs.Close();
            } else {
                //create default config now
                FileStream fs = new FileStream(cfgFile, FileMode.Create, FileAccess.ReadWrite);
                ser.Serialize(fs, cfg);
                fs.Flush();
                fs.Close(); 
            }

            return cfg;
        }

        private void saveConfig(ProgConfig cfg)
        {
            XmlSerializer ser = new XmlSerializer(typeof(ProgConfig));

            string cfgFile = Application.StartupPath + "\\config.xml";
            FileStream fs = new FileStream(cfgFile, FileMode.Create, FileAccess.ReadWrite);
            ser.Serialize(fs, cfg);
            fs.Flush();
            fs.Close(); 
        }

        void heatmapTimer_Tick(object sender, EventArgs e) {
            redrawPoly(); 
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            
            if(e != null) { 
                object[] data = (object[])e.UserState;
                GMap.NET.PointLatLng newPos = new GMap.NET.PointLatLng(Convert.ToDouble(data[0]), Convert.ToDouble(data[1]));
                int time = Convert.ToInt32(data[2]);

                resCfg.resultsData.Rows.Add(newPos.Lat, newPos.Lng, time);
                addMarker(newPos, time);
                try { 
                    int oldNum = Convert.ToInt32(label10.Text.Split(' ')[1]) - 1;
                    label10.Text = "ToDo: " + oldNum;
                } catch {

                }
            }
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            BackgroundWorker bgw = sender as BackgroundWorker;
            if (workers.Contains(bgw)) {
                workers.Remove(bgw);
            }

            if(workers.Count == 0) {
                heatmapTimer.Stop();
                prev_markers.Markers.Clear();
                label10.Text = "ToDo: 0";
                progressBar1.Hide();
                redrawPoly();

                numericUpDownEast.Enabled = true;
                numericUpDownWest.Enabled = true;
                numericUpDownNorth.Enabled = true;
                numericUpDownSouth.Enabled = true;
                numericUpDownPitch.Enabled = true;
                numericUpDownThreads.Enabled = true;

                if (markers.Markers.Count == 0) {
                    MessageBox.Show("Sorry, no routes found :-(");
                }
            }
        }

        private void redrawPoly() {
            polygons.Polygons.Clear();
            foreach (DataRow ro in resCfg.resultsData.Rows) {
                if (ro.ItemArray.Length > 2) {
                    GMap.NET.PointLatLng newPos2 = new GMap.NET.PointLatLng(Convert.ToDouble(ro.ItemArray[0]), Convert.ToDouble(ro.ItemArray[1]));
                    int time2 = Convert.ToInt32(ro.ItemArray[2]);

                    if (time2 > 0) {
                        if (checkBoxUseBounds.Checked) {
                            if (time2 >= resCfg.minShowTime && time2 <= resCfg.maxShowTime) {
                                calcPolygon(newPos2, time2, resCfg.pitch);
                            }
                        } else {
                            calcPolygon(newPos2, time2, resCfg.pitch);
                        }
                    }
                }
            }

            int maxTime;
            int minTime;

            if (checkBoxUseBounds.Checked) {
                maxTime = resCfg.maxShowTime;
                minTime = resCfg.minShowTime;
            } else {
                maxTime = resCfg.maxTime;
                minTime = resCfg.minTime;
            }

            labelLegend1.Text  = (minTime + 0 * ((double)(maxTime - minTime) / (double)10)).ToString();
            labelLegend2.Text  = (minTime + 1 * ((double)(maxTime - minTime) / (double)10)).ToString();
            labelLegend3.Text  = (minTime + 2 * ((double)(maxTime - minTime) / (double)10)).ToString();
            labelLegend4.Text  = (minTime + 3 * ((double)(maxTime - minTime) / (double)10)).ToString();
            labelLegend5.Text  = (minTime + 4 * ((double)(maxTime - minTime) / (double)10)).ToString();
            labelLegend6.Text  = (minTime + 5 * ((double)(maxTime - minTime) / (double)10)).ToString();
            labelLegend7.Text  = (minTime + 6 * ((double)(maxTime - minTime) / (double)10)).ToString();
            labelLegend8.Text  = (minTime + 7 * ((double)(maxTime - minTime) / (double)10)).ToString();
            labelLegend9.Text  = (minTime + 8 * ((double)(maxTime - minTime) / (double)10)).ToString();
            labelLegend10.Text = (minTime + 9 * ((double)(maxTime - minTime) / (double)10)).ToString();
            labelLegend11.Text = (minTime + 10 * ((double)(maxTime - minTime) / (double)10)).ToString();
            
        }

        void worker_DoWork(object sender, DoWorkEventArgs eArgs) {
            bool doWork = true;
            BackgroundWorker worker = sender as BackgroundWorker;
            while (doWork) {
                QueueMutex.WaitOne();
                if (resCfg.pointsQueue.Count > 0) {
                    GMap.NET.PointLatLng newPoint = resCfg.pointsQueue.Dequeue();
                    QueueMutex.ReleaseMutex();

                    //do slow stuff here
                    int time = getTravelTimeFromGoogle(newPoint, resCfg.centerPos).Item1;
                    worker.ReportProgress(1, new object[] { newPoint.Lat, newPoint.Lng, time });



                } else {
                    QueueMutex.ReleaseMutex();
                    doWork = false;
                }
            }
        }

        private void addMarker(GMap.NET.PointLatLng newPos, int time) {
            if (time > 0) {
                if (time > resCfg.maxTime) {   //found new max value
                    resCfg.maxTime = time;
                    trackBarUpperBound.Maximum = time;
                    trackBarLowerBound.Maximum = time;
                    if (!checkBoxUseBounds.Checked) {
                        textBoxUpperBound.Text = time.ToString();   //adjust label
                        trackBarUpperBound.Value = time;            //and value
                    }
                }
                if (time < resCfg.minTime) {
                    resCfg.minTime = time;
                    trackBarUpperBound.Minimum = time;
                    trackBarLowerBound.Minimum = time;
                    if (!checkBoxUseBounds.Checked) {
                        textBoxLowerBound.Text = time.ToString();
                        trackBarLowerBound.Value = time;
                    }
                }

                


                GMap.NET.WindowsForms.GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    newPos,
                    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green_small);
                marker.ToolTipText = time.ToString();
                marker.ToolTipMode = GMap.NET.WindowsForms.MarkerTooltipMode.OnMouseOver;
                marker.ToolTip.Fill = Brushes.Black;
                marker.ToolTip.Foreground = Brushes.White;
                marker.ToolTip.Stroke = Pens.Black;
                marker.ToolTip.TextPadding = new Size(20, 20);

                markers.Markers.Add(marker);
            }
        }

        private void addMarker_prev(GMap.NET.PointLatLng newPos) {
            GMap.NET.WindowsForms.GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                newPos,
                GMap.NET.WindowsForms.Markers.GMarkerGoogleType.white_small);

            prev_markers.Markers.Add(marker);
            
        }

        private void calcPolygon(GMap.NET.PointLatLng newPos, int time, double pitch) {

            if (time > resCfg.maxTime) {   //found new max value
                resCfg.maxTime = time;
                trackBarUpperBound.Maximum = time;
                trackBarLowerBound.Maximum = time;
                if (!checkBoxUseBounds.Checked) {
                    textBoxUpperBound.Text = time.ToString();   //adjust label
                    trackBarUpperBound.Value = time;            //and value
                }
            }
            if (time < resCfg.minTime) {
                resCfg.minTime = time;
                trackBarUpperBound.Minimum = time;
                trackBarLowerBound.Minimum = time;
                if (!checkBoxUseBounds.Checked) {
                    textBoxLowerBound.Text = time.ToString();
                    trackBarLowerBound.Value = time;
                }
            }

            List<GMap.NET.PointLatLng> points = new List<GMap.NET.PointLatLng>();
            points.Add(getNewCoordinates_gmap(newPos, pitch / 2, pitch / 2));
            points.Add(getNewCoordinates_gmap(newPos, pitch / 2, -pitch / 2));
            points.Add(getNewCoordinates_gmap(newPos, -pitch / 2, -pitch / 2));
            points.Add(getNewCoordinates_gmap(newPos, -pitch / 2, pitch / 2));

            GMap.NET.WindowsForms.GMapPolygon poly = new GMap.NET.WindowsForms.GMapPolygon(points, newPos.Lat.ToString() + "," + newPos.Lng.ToString());

            if (checkBoxUseBounds.Checked) {
                poly.Fill = new SolidBrush(getHeatmapColor(resCfg.minShowTime, resCfg.maxShowTime, time, 200));
                poly.Stroke = new Pen(getHeatmapColor(resCfg.minShowTime, resCfg.maxShowTime, time, 50), 1);
            } else {

                poly.Fill = new SolidBrush(getHeatmapColor(resCfg.minTime, resCfg.maxTime, time, 200));
                poly.Stroke = new Pen(getHeatmapColor(resCfg.minTime, resCfg.maxTime, time, 50), 1);
            }
            
            polygons.Polygons.Add(poly);
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs eArgs) {
            if (this.Text == "Unsaved") {
                DialogResult res = MessageBox.Show("Previous changes not saved. Continuing will dsicard the data. Do you want to continue anyways?", "Override data?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (res == System.Windows.Forms.DialogResult.Yes) {
                    startDataAcquisition();
                }
            } else {
                startDataAcquisition();
            }
        }

        private void startDataAcquisition() {

            numericUpDown_ValueChanged(null, null);

            numericUpDownEast.Enabled = false;
            numericUpDownWest.Enabled = false;
            numericUpDownNorth.Enabled = false;
            numericUpDownSouth.Enabled = false;
            numericUpDownPitch.Enabled = false;
            numericUpDownThreads.Enabled = false;
            
            
            this.Text = "Unsaved";

            markers.Markers.Clear();
            polygons.Polygons.Clear();

            gMapControl1.Invalidate();
            resCfg.resultsData.Clear();

            progressBar1.Show();


            int numThraeds = Convert.ToInt32(numericUpDownThreads.Value);
            workers.Clear();
            for (int i = 0; i < numThraeds; i++) {

                BackgroundWorker worker = new BackgroundWorker();
                worker.DoWork += worker_DoWork;
                worker.ProgressChanged += worker_ProgressChanged;
                worker.RunWorkerCompleted += worker_RunWorkerCompleted;
                worker.WorkerReportsProgress = true;
                worker.RunWorkerAsync();
                workers.Add(worker);
            }

            heatmapTimer.Start();
        }

        private Color getHeatmapColor(double min, double max, double val, int alpha) {
            max -= min; //bring values down to zero offset
            val -= min;

            if (max > 0) {
                double g = (val > max / 2 ? 1 - 2 * (val - max / 2) / max : 1.0);
                double r = (val > max / 2 ? 1.0 : 2 * val / max);
                double b = 0.0;

                int red = Convert.ToInt32(r * 255);
                int green = Convert.ToInt32(g * 255);
                int blue = Convert.ToInt32(b * 255);

                if (red < 0) red = 0;
                if (green < 0) green = 0;
                if (blue < 0) blue = 0;

                return Color.FromArgb(alpha, red, green, blue);
            } else {
                return Color.FromArgb(alpha, Color.Red);    //new minimum --> red
            }
        }

        private Tuple<int, string> getTravelTimeFromGoogle(GMap.NET.PointLatLng start, GMap.NET.PointLatLng end) {
            string startLat = start.Lat.ToString(CultureInfo.InvariantCulture);
            string startLong = start.Lng.ToString(CultureInfo.InvariantCulture);
            string endLat = end.Lat.ToString(CultureInfo.InvariantCulture);
            string endLong = end.Lng.ToString(CultureInfo.InvariantCulture);

            string requestString = @"https://maps.googleapis.com/maps/api/directions/json?origin=""" +
                HttpUtility.UrlEncode(startLat + " " + startLong) +
                @"""&destination=""" +
                HttpUtility.UrlEncode(endLat + " " + endLong) +
                @"""&key=" + progCfg.apiKey;// "AIzaSyB5XXl4PRbZaOaiSZ3oVreMcOF6g36xRh4";
            try {

                HttpWebRequest request = WebRequest.Create(requestString) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string responseContent = reader.ReadToEnd().Trim();
                dynamic jsonobject = JsonConvert.DeserializeObject(responseContent);

                if (jsonobject["error_message"] != null)
                {
                    if(((string)jsonobject["error_message"]).StartsWith("This IP, site or mobile"))
                    {
                        return new Tuple<int, string>(-1, "IP not allowed!");
                    }
                    else
                    {
                        return new Tuple<int, string>(-1, "unknown!");
                    }
                    
                }
                    

                if (jsonobject.geocoded_waypoints[0].geocoder_status == "ZERO_RESULTS") {
                    return new Tuple<int, string>(-1, "ZERO_RESULTS"); ;
                } else if (jsonobject.status == "NOT_FOUND") {
                    return new Tuple<int, string>(-1, "NOT_FOUND");
                } else {
                    if (jsonobject.routes.Count > 0) {
                        if (jsonobject.routes[0].legs.Count > 0) {
                            return new Tuple<int, string>(Convert.ToInt32(jsonobject.routes[0].legs[0].duration.value), "OK");
                        } else {
                            return new Tuple<int, string>(-1, "routes[0].legs.Count <= 0");
                        }

                    } else {
                        return new Tuple<int, string>(-1, "routes.Count <= 0");
                    }
                }
            } catch (Exception e){
                return new Tuple<int, string>(-1, e.Message);
            }
        }


        private GMap.NET.PointLatLng getNewCoordinates_gmap(GMap.NET.PointLatLng currentPosition, double dx, double dy) {
            int r_earth = 6378;
            GMap.NET.PointLatLng newPos = new GMap.NET.PointLatLng(
                currentPosition.Lat + ((double)dy / (double)r_earth) * (180.0 / Math.PI),
                currentPosition.Lng + ((double)dx / (double)r_earth) * (180.0 / Math.PI) / Math.Cos(currentPosition.Lat * Math.PI / 180.0));
            return newPos;
        }

        private void textBoxStartLat_TextChanged(object sender, EventArgs e) {
            TextBox tb = sender as TextBox;
            tb.Text = tb.Text.Replace(",", ".");
        }

        private void textBoxStartLong_TextChanged(object sender, EventArgs e) {
            TextBox tb = sender as TextBox;
            tb.Text = tb.Text.Replace(",", ".");
        }

        private void checkBoxShowMarkers_CheckedChanged(object sender, EventArgs e) {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked) {
                if (gMapControl1.Overlays.Contains(markers) == false) {
                    gMapControl1.Overlays.Add(markers);
                }
            } else {
                if (gMapControl1.Overlays.Contains(markers) == true) {
                    gMapControl1.Overlays.Remove(markers);
                }
            }

        }

        private void checkBoxShowColors_CheckedChanged(object sender, EventArgs e) {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked) {
                if (gMapControl1.Overlays.Contains(polygons) == false) {
                    gMapControl1.Overlays.Add(polygons);
                }
            } else {
                if (gMapControl1.Overlays.Contains(polygons) == true) {
                    gMapControl1.Overlays.Remove(polygons);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            XmlSerializer ser = new XmlSerializer(typeof(ConfigResults));

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML-Dokument|*.xml";

            dialog.FileName = "results-" + DateTime.Now.ToString("yyyy-MMM-dd_hh-mm") + ".xml";

            DialogResult res = dialog.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK) {
                FileStream fs = new FileStream(dialog.FileName, FileMode.Create, FileAccess.ReadWrite);
                ser.Serialize(fs, resCfg);
                fs.Flush();
                fs.Close();

                this.Text = "Saved to " + dialog.FileName;
            }

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            XmlSerializer ser = new XmlSerializer(typeof(ConfigResults));

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML-Dokument|*.xml";

            DialogResult res = dialog.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK) {
                FileStream fs = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read);
                resCfg = (ConfigResults)ser.Deserialize(fs);

                markers.Markers.Clear();
                polygons.Polygons.Clear();
                gMapControl1.Invalidate();

                foreach (DataRow ro in resCfg.resultsData.Rows) {
                    if (ro.ItemArray.Length > 2) {
                        GMap.NET.PointLatLng newPos = new GMap.NET.PointLatLng(Convert.ToDouble(ro.ItemArray[0]), Convert.ToDouble(ro.ItemArray[1]));
                        int time = Convert.ToInt32(ro.ItemArray[2]);

                        if (time > 0) {
                            addMarker(newPos, time);
                            calcPolygon(newPos, time, resCfg.pitch);
                        }
                    }
                }

                fs.Flush();
                fs.Close();

                this.Text = "Loaded " + dialog.FileName;
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs eArgs) {
            
            
            resCfg.centerPos = new GMap.NET.PointLatLng(
                Convert.ToDouble(textBoxStartLat.Text, CultureInfo.InvariantCulture),
                Convert.ToDouble(textBoxStartLong.Text, CultureInfo.InvariantCulture));

            prev_markers.Markers.Clear();
            GMap.NET.PointLatLng newPos = new GMap.NET.PointLatLng();
            resCfg.pointsQueue = new Queue<GMap.NET.PointLatLng>();

            resCfg.pitch = Convert.ToDouble(numericUpDownPitch.Value);

            //North
            if (numericUpDownNorth.Value > (decimal)resCfg.pitch) {
                for (decimal n = 0; n <= numericUpDownNorth.Value; n += (decimal)resCfg.pitch) {
                    //straight up North
                    if (numericUpDownEast.Value == 0 && numericUpDownWest.Value == 0) {
                        if (n == 0) continue;
                        newPos = getNewCoordinates_gmap(resCfg.centerPos, 0, (double)n);
                        addMarker_prev(newPos);
                        resCfg.pointsQueue.Enqueue(newPos);
                    } else {
                        //North East
                        if (numericUpDownEast.Value > (decimal)resCfg.pitch) {
                            for (decimal e = 0; e <= numericUpDownEast.Value; e += (decimal)resCfg.pitch) {
                                if (n == 0 && e == 0) continue;
                                newPos = getNewCoordinates_gmap(resCfg.centerPos, (double)e, (double)n);
                                addMarker_prev(newPos);
                                resCfg.pointsQueue.Enqueue(newPos);
                            }
                        }

                        //North west
                        if (numericUpDownWest.Value > (decimal)resCfg.pitch) {
                            for (decimal w = (decimal)resCfg.pitch; w <= numericUpDownWest.Value; w += (decimal)resCfg.pitch) {
                                if (n == 0 && w == 0) continue;
                                newPos = getNewCoordinates_gmap(resCfg.centerPos, -(double)w, (double)n);
                                addMarker_prev(newPos);
                                resCfg.pointsQueue.Enqueue(newPos);
                            }
                        }
                    }
                }
            }

            //South
            if (numericUpDownSouth.Value > (decimal)resCfg.pitch) {
                for (decimal s = (decimal)resCfg.pitch; s <= numericUpDownSouth.Value; s += (decimal)resCfg.pitch) {
                    //straight up South
                    if (numericUpDownEast.Value == 0 && numericUpDownWest.Value == 0) {
                        if (s == 0) continue;
                        newPos = getNewCoordinates_gmap(resCfg.centerPos, 0, -(double)s);
                        addMarker_prev(newPos);
                        resCfg.pointsQueue.Enqueue(newPos);
                    } else {
                        //South East
                        if (numericUpDownEast.Value > (decimal)resCfg.pitch) {
                            for (decimal e = 0; e <= numericUpDownEast.Value; e += (decimal)resCfg.pitch) {
                                if (s == 0 && e == 0) continue;
                                newPos = getNewCoordinates_gmap(resCfg.centerPos, (double)e, -(double)s);
                                addMarker_prev(newPos);
                                resCfg.pointsQueue.Enqueue(newPos);
                            }
                        }

                        //South west
                        if (numericUpDownWest.Value > (decimal)resCfg.pitch) {
                            for (decimal w = (decimal)resCfg.pitch; w <= numericUpDownWest.Value; w += (decimal)resCfg.pitch) {
                                if (s == 0 && w == 0) continue;
                                newPos = getNewCoordinates_gmap(resCfg.centerPos, -(double)w, -(double)s);
                                addMarker_prev(newPos);
                                resCfg.pointsQueue.Enqueue(newPos);
                            }
                        }
                    }
                }
            }

            label10.Text = "ToDo: " + resCfg.pointsQueue.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            gMapControl1.Position = new GMap.NET.PointLatLng(
                Convert.ToDouble(textBoxStartLat.Text, CultureInfo.InvariantCulture),
                Convert.ToDouble(textBoxStartLong.Text, CultureInfo.InvariantCulture));
            resCfg.centerPos = gMapControl1.Position;
            numericUpDown_ValueChanged(null, null);

            this.progCfg.centerPos = gMapControl1.Position;
        }

        private void trackBar1_Scroll(object sender, EventArgs e) {

        }

        private void label11_Click(object sender, EventArgs e) {

        }

        private void checkBoxUseBounds_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxUseBounds.Checked) {
                trackBarLowerBound.Enabled = true;
                trackBarUpperBound.Enabled = true;
                textBoxLowerBound.Enabled  = true;
                textBoxUpperBound.Enabled  = true;

                resCfg.maxShowTime = resCfg.maxTime;
                resCfg.minShowTime = resCfg.minTime;
            } else {
                trackBarLowerBound.Enabled = false;
                trackBarUpperBound.Enabled = false;
                textBoxLowerBound.Enabled =  false;
                textBoxUpperBound.Enabled =  false;

                textBoxLowerBound.Text = resCfg.minTime.ToString();
                textBoxUpperBound.Text = resCfg.maxTime.ToString();

                resCfg.maxShowTime = resCfg.maxTime;
                resCfg.minShowTime = resCfg.minTime;
            }
        }

        private void trackBarUpperBound_Scroll(object sender, EventArgs e) {
            resCfg.maxShowTime = trackBarUpperBound.Value;
            textBoxUpperBound.Text = resCfg.maxShowTime.ToString();
            redrawPoly();
        }

        private void trackBarLowerBound_Scroll(object sender, EventArgs e) {
            resCfg.minShowTime = trackBarLowerBound.Value;
            textBoxLowerBound.Text = resCfg.minShowTime.ToString();
            redrawPoly();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            saveConfig(progCfg);
        }

        private void button3_Click(object sender, EventArgs e) {
            textBoxStartLat.Text = gMapControl1.Position.Lat.ToString();
            textBoxStartLong.Text = gMapControl1.Position.Lng.ToString();

            resCfg.centerPos = gMapControl1.Position;
            numericUpDown_ValueChanged(null, null);

            this.progCfg.centerPos = gMapControl1.Position;
        }
    }

    public class ConfigResults
    {
        public DataTable resultsData;
        public double pitch = 0.0;

        [XmlIgnore]
        public Queue<GMap.NET.PointLatLng> pointsQueue = new Queue<GMap.NET.PointLatLng>();


        public GMap.NET.PointLatLng centerPos = new GMap.NET.PointLatLng();
        public int minTime = int.MaxValue;
        public int maxTime = 0;

        public int minShowTime = 0;
        public int maxShowTime = 0;
        public ConfigResults() {
            resultsData = new DataTable("results");
            resultsData.Columns.Add("Lat");
            resultsData.Columns.Add("Long");
            resultsData.Columns.Add("Time");
        }

        
    }

    class newLabel : System.Windows.Forms.Label
    {
        public int RotateAngle { get; set; }
        public string NewText { get; set; }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) {
            Brush b = new SolidBrush(this.ForeColor);
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.RotateTransform(this.RotateAngle);
            e.Graphics.DrawString(this.NewText, this.Font, b, 0f, 0f);
            base.OnPaint(e);
        }
    }
}
