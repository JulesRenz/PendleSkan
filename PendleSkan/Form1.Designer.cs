namespace PendleSkan
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStartLong = new System.Windows.Forms.TextBox();
            this.textBoxStartLat = new System.Windows.Forms.TextBox();
            this.numericUpDownNorth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEast = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSouth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWest = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownThreads = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDownPitch = new System.Windows.Forms.NumericUpDown();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.checkBoxShowMarkers = new System.Windows.Forms.CheckBox();
            this.checkBoxShowColors = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxUseBounds = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxLowerBound = new System.Windows.Forms.TextBox();
            this.textBoxUpperBound = new System.Windows.Forms.TextBox();
            this.trackBarUpperBound = new System.Windows.Forms.TrackBar();
            this.trackBarLowerBound = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxLegend11 = new System.Windows.Forms.TextBox();
            this.labelLegend1 = new System.Windows.Forms.Label();
            this.textBoxLegend1 = new System.Windows.Forms.TextBox();
            this.labelLegend2 = new System.Windows.Forms.Label();
            this.textBoxLegend2 = new System.Windows.Forms.TextBox();
            this.labelLegend3 = new System.Windows.Forms.Label();
            this.textBoxLegend3 = new System.Windows.Forms.TextBox();
            this.labelLegend4 = new System.Windows.Forms.Label();
            this.textBoxLegend4 = new System.Windows.Forms.TextBox();
            this.labelLegend5 = new System.Windows.Forms.Label();
            this.textBoxLegend8 = new System.Windows.Forms.TextBox();
            this.labelLegend6 = new System.Windows.Forms.Label();
            this.textBoxLegend7 = new System.Windows.Forms.TextBox();
            this.labelLegend7 = new System.Windows.Forms.Label();
            this.textBoxLegend6 = new System.Windows.Forms.TextBox();
            this.labelLegend8 = new System.Windows.Forms.Label();
            this.textBoxLegend5 = new System.Windows.Forms.TextBox();
            this.labelLegend9 = new System.Windows.Forms.Label();
            this.textBoxLegend9 = new System.Windows.Forms.TextBox();
            this.labelLegend10 = new System.Windows.Forms.Label();
            this.textBoxLegend10 = new System.Windows.Forms.TextBox();
            this.labelLegend11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSouth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWest)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPitch)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUpperBound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLowerBound)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "GO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxStartLong);
            this.groupBox1.Controls.Add(this.textBoxStartLat);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "goto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Longitude";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Latitude";
            // 
            // textBoxStartLong
            // 
            this.textBoxStartLong.Location = new System.Drawing.Point(60, 45);
            this.textBoxStartLong.Name = "textBoxStartLong";
            this.textBoxStartLong.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartLong.TabIndex = 1;
            this.textBoxStartLong.TextChanged += new System.EventHandler(this.textBoxStartLong_TextChanged);
            // 
            // textBoxStartLat
            // 
            this.textBoxStartLat.Location = new System.Drawing.Point(60, 19);
            this.textBoxStartLat.Name = "textBoxStartLat";
            this.textBoxStartLat.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartLat.TabIndex = 0;
            this.textBoxStartLat.TextChanged += new System.EventHandler(this.textBoxStartLat_TextChanged);
            // 
            // numericUpDownNorth
            // 
            this.numericUpDownNorth.Location = new System.Drawing.Point(102, 31);
            this.numericUpDownNorth.Name = "numericUpDownNorth";
            this.numericUpDownNorth.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownNorth.TabIndex = 4;
            this.numericUpDownNorth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNorth.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownEast
            // 
            this.numericUpDownEast.Location = new System.Drawing.Point(154, 57);
            this.numericUpDownEast.Name = "numericUpDownEast";
            this.numericUpDownEast.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownEast.TabIndex = 6;
            this.numericUpDownEast.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownEast.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownSouth
            // 
            this.numericUpDownSouth.Location = new System.Drawing.Point(102, 83);
            this.numericUpDownSouth.Name = "numericUpDownSouth";
            this.numericUpDownSouth.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownSouth.TabIndex = 7;
            this.numericUpDownSouth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownSouth.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownWest
            // 
            this.numericUpDownWest.Location = new System.Drawing.Point(50, 57);
            this.numericUpDownWest.Name = "numericUpDownWest";
            this.numericUpDownWest.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownWest.TabIndex = 8;
            this.numericUpDownWest.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownWest.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "North";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "South";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "West";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "East";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.numericUpDownThreads);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.numericUpDownPitch);
            this.groupBox2.Controls.Add(this.numericUpDownSouth);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericUpDownNorth);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.numericUpDownEast);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericUpDownWest);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(3, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 236);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grid Online";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(124, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Threads";
            // 
            // numericUpDownThreads
            // 
            this.numericUpDownThreads.Location = new System.Drawing.Point(7, 203);
            this.numericUpDownThreads.Name = "numericUpDownThreads";
            this.numericUpDownThreads.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownThreads.TabIndex = 17;
            this.numericUpDownThreads.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "km";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pitch";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(87, 173);
            this.progressBar1.MarqueeAnimationSpeed = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(175, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 16;
            // 
            // numericUpDownPitch
            // 
            this.numericUpDownPitch.DecimalPlaces = 1;
            this.numericUpDownPitch.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownPitch.Location = new System.Drawing.Point(47, 137);
            this.numericUpDownPitch.Name = "numericUpDownPitch";
            this.numericUpDownPitch.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownPitch.TabIndex = 13;
            this.numericUpDownPitch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPitch.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(303, 33);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 20;
            this.gMapControl1.MinZoom = 1;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(696, 650);
            this.gMapControl1.TabIndex = 15;
            this.gMapControl1.Zoom = 10D;
            // 
            // checkBoxShowMarkers
            // 
            this.checkBoxShowMarkers.AutoSize = true;
            this.checkBoxShowMarkers.Checked = true;
            this.checkBoxShowMarkers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowMarkers.Location = new System.Drawing.Point(3, 4);
            this.checkBoxShowMarkers.Name = "checkBoxShowMarkers";
            this.checkBoxShowMarkers.Size = new System.Drawing.Size(94, 17);
            this.checkBoxShowMarkers.TabIndex = 17;
            this.checkBoxShowMarkers.Text = "Show Markers";
            this.checkBoxShowMarkers.UseVisualStyleBackColor = true;
            this.checkBoxShowMarkers.CheckedChanged += new System.EventHandler(this.checkBoxShowMarkers_CheckedChanged);
            // 
            // checkBoxShowColors
            // 
            this.checkBoxShowColors.AutoSize = true;
            this.checkBoxShowColors.Checked = true;
            this.checkBoxShowColors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowColors.Location = new System.Drawing.Point(103, 4);
            this.checkBoxShowColors.Name = "checkBoxShowColors";
            this.checkBoxShowColors.Size = new System.Drawing.Size(85, 17);
            this.checkBoxShowColors.TabIndex = 18;
            this.checkBoxShowColors.Text = "Show Colors";
            this.checkBoxShowColors.UseVisualStyleBackColor = true;
            this.checkBoxShowColors.CheckedChanged += new System.EventHandler(this.checkBoxShowColors_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.loadToolStripMenuItem.Text = "load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gMapControl1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1002, 686);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(294, 680);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxUseBounds);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textBoxLowerBound);
            this.groupBox4.Controls.Add(this.textBoxUpperBound);
            this.groupBox4.Controls.Add(this.trackBarUpperBound);
            this.groupBox4.Controls.Add(this.trackBarLowerBound);
            this.groupBox4.Location = new System.Drawing.Point(90, 331);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 314);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter";
            // 
            // checkBoxUseBounds
            // 
            this.checkBoxUseBounds.AutoSize = true;
            this.checkBoxUseBounds.Location = new System.Drawing.Point(9, 19);
            this.checkBoxUseBounds.Name = "checkBoxUseBounds";
            this.checkBoxUseBounds.Size = new System.Drawing.Size(135, 17);
            this.checkBoxUseBounds.TabIndex = 44;
            this.checkBoxUseBounds.Text = "Filter Displayed Results";
            this.checkBoxUseBounds.UseVisualStyleBackColor = true;
            this.checkBoxUseBounds.CheckedChanged += new System.EventHandler(this.checkBoxUseBounds_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(66, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Stop";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Start";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBoxLowerBound
            // 
            this.textBoxLowerBound.Enabled = false;
            this.textBoxLowerBound.Location = new System.Drawing.Point(9, 286);
            this.textBoxLowerBound.Name = "textBoxLowerBound";
            this.textBoxLowerBound.Size = new System.Drawing.Size(45, 20);
            this.textBoxLowerBound.TabIndex = 41;
            // 
            // textBoxUpperBound
            // 
            this.textBoxUpperBound.Enabled = false;
            this.textBoxUpperBound.Location = new System.Drawing.Point(69, 60);
            this.textBoxUpperBound.Name = "textBoxUpperBound";
            this.textBoxUpperBound.Size = new System.Drawing.Size(45, 20);
            this.textBoxUpperBound.TabIndex = 40;
            // 
            // trackBarUpperBound
            // 
            this.trackBarUpperBound.Enabled = false;
            this.trackBarUpperBound.Location = new System.Drawing.Point(69, 86);
            this.trackBarUpperBound.Name = "trackBarUpperBound";
            this.trackBarUpperBound.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarUpperBound.Size = new System.Drawing.Size(45, 221);
            this.trackBarUpperBound.TabIndex = 39;
            this.trackBarUpperBound.Value = 10;
            this.trackBarUpperBound.Scroll += new System.EventHandler(this.trackBarUpperBound_Scroll);
            // 
            // trackBarLowerBound
            // 
            this.trackBarLowerBound.Enabled = false;
            this.trackBarLowerBound.Location = new System.Drawing.Point(9, 59);
            this.trackBarLowerBound.Name = "trackBarLowerBound";
            this.trackBarLowerBound.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarLowerBound.Size = new System.Drawing.Size(45, 221);
            this.trackBarLowerBound.TabIndex = 38;
            this.trackBarLowerBound.Scroll += new System.EventHandler(this.trackBarLowerBound_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxLegend11);
            this.groupBox3.Controls.Add(this.labelLegend1);
            this.groupBox3.Controls.Add(this.textBoxLegend1);
            this.groupBox3.Controls.Add(this.labelLegend2);
            this.groupBox3.Controls.Add(this.textBoxLegend2);
            this.groupBox3.Controls.Add(this.labelLegend3);
            this.groupBox3.Controls.Add(this.textBoxLegend3);
            this.groupBox3.Controls.Add(this.labelLegend4);
            this.groupBox3.Controls.Add(this.textBoxLegend4);
            this.groupBox3.Controls.Add(this.labelLegend5);
            this.groupBox3.Controls.Add(this.textBoxLegend8);
            this.groupBox3.Controls.Add(this.labelLegend6);
            this.groupBox3.Controls.Add(this.textBoxLegend7);
            this.groupBox3.Controls.Add(this.labelLegend7);
            this.groupBox3.Controls.Add(this.textBoxLegend6);
            this.groupBox3.Controls.Add(this.labelLegend8);
            this.groupBox3.Controls.Add(this.textBoxLegend5);
            this.groupBox3.Controls.Add(this.labelLegend9);
            this.groupBox3.Controls.Add(this.textBoxLegend9);
            this.groupBox3.Controls.Add(this.labelLegend10);
            this.groupBox3.Controls.Add(this.textBoxLegend10);
            this.groupBox3.Controls.Add(this.labelLegend11);
            this.groupBox3.Location = new System.Drawing.Point(3, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(83, 314);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Map Colors";
            // 
            // textBoxLegend11
            // 
            this.textBoxLegend11.BackColor = System.Drawing.Color.Red;
            this.textBoxLegend11.Location = new System.Drawing.Point(3, 16);
            this.textBoxLegend11.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLegend11.Name = "textBoxLegend11";
            this.textBoxLegend11.Size = new System.Drawing.Size(20, 20);
            this.textBoxLegend11.TabIndex = 24;
            // 
            // labelLegend1
            // 
            this.labelLegend1.AutoSize = true;
            this.labelLegend1.Location = new System.Drawing.Point(26, 219);
            this.labelLegend1.Name = "labelLegend1";
            this.labelLegend1.Size = new System.Drawing.Size(10, 13);
            this.labelLegend1.TabIndex = 35;
            this.labelLegend1.Text = "-";
            // 
            // textBoxLegend1
            // 
            this.textBoxLegend1.BackColor = System.Drawing.Color.Lime;
            this.textBoxLegend1.Location = new System.Drawing.Point(3, 216);
            this.textBoxLegend1.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLegend1.Name = "textBoxLegend1";
            this.textBoxLegend1.Size = new System.Drawing.Size(20, 20);
            this.textBoxLegend1.TabIndex = 14;
            // 
            // labelLegend2
            // 
            this.labelLegend2.AutoSize = true;
            this.labelLegend2.Location = new System.Drawing.Point(26, 199);
            this.labelLegend2.Name = "labelLegend2";
            this.labelLegend2.Size = new System.Drawing.Size(10, 13);
            this.labelLegend2.TabIndex = 34;
            this.labelLegend2.Text = "-";
            // 
            // textBoxLegend2
            // 
            this.textBoxLegend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.textBoxLegend2.Location = new System.Drawing.Point(3, 196);
            this.textBoxLegend2.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLegend2.Name = "textBoxLegend2";
            this.textBoxLegend2.Size = new System.Drawing.Size(20, 20);
            this.textBoxLegend2.TabIndex = 15;
            // 
            // labelLegend3
            // 
            this.labelLegend3.AutoSize = true;
            this.labelLegend3.Location = new System.Drawing.Point(26, 179);
            this.labelLegend3.Name = "labelLegend3";
            this.labelLegend3.Size = new System.Drawing.Size(10, 13);
            this.labelLegend3.TabIndex = 33;
            this.labelLegend3.Text = "-";
            // 
            // textBoxLegend3
            // 
            this.textBoxLegend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.textBoxLegend3.Location = new System.Drawing.Point(3, 176);
            this.textBoxLegend3.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLegend3.Name = "textBoxLegend3";
            this.textBoxLegend3.Size = new System.Drawing.Size(20, 20);
            this.textBoxLegend3.TabIndex = 16;
            // 
            // labelLegend4
            // 
            this.labelLegend4.AutoSize = true;
            this.labelLegend4.Location = new System.Drawing.Point(26, 159);
            this.labelLegend4.Name = "labelLegend4";
            this.labelLegend4.Size = new System.Drawing.Size(10, 13);
            this.labelLegend4.TabIndex = 32;
            this.labelLegend4.Text = "-";
            // 
            // textBoxLegend4
            // 
            this.textBoxLegend4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.textBoxLegend4.Location = new System.Drawing.Point(3, 156);
            this.textBoxLegend4.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLegend4.Name = "textBoxLegend4";
            this.textBoxLegend4.Size = new System.Drawing.Size(20, 20);
            this.textBoxLegend4.TabIndex = 17;
            // 
            // labelLegend5
            // 
            this.labelLegend5.AutoSize = true;
            this.labelLegend5.Location = new System.Drawing.Point(26, 139);
            this.labelLegend5.Name = "labelLegend5";
            this.labelLegend5.Size = new System.Drawing.Size(10, 13);
            this.labelLegend5.TabIndex = 31;
            this.labelLegend5.Text = "-";
            // 
            // textBoxLegend8
            // 
            this.textBoxLegend8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.textBoxLegend8.Location = new System.Drawing.Point(3, 136);
            this.textBoxLegend8.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLegend8.Name = "textBoxLegend8";
            this.textBoxLegend8.Size = new System.Drawing.Size(20, 20);
            this.textBoxLegend8.TabIndex = 18;
            // 
            // labelLegend6
            // 
            this.labelLegend6.AutoSize = true;
            this.labelLegend6.Location = new System.Drawing.Point(26, 119);
            this.labelLegend6.Name = "labelLegend6";
            this.labelLegend6.Size = new System.Drawing.Size(10, 13);
            this.labelLegend6.TabIndex = 30;
            this.labelLegend6.Text = "-";
            // 
            // textBoxLegend7
            // 
            this.textBoxLegend7.BackColor = System.Drawing.Color.Yellow;
            this.textBoxLegend7.Location = new System.Drawing.Point(3, 116);
            this.textBoxLegend7.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLegend7.Name = "textBoxLegend7";
            this.textBoxLegend7.Size = new System.Drawing.Size(20, 20);
            this.textBoxLegend7.TabIndex = 19;
            // 
            // labelLegend7
            // 
            this.labelLegend7.AutoSize = true;
            this.labelLegend7.Location = new System.Drawing.Point(26, 99);
            this.labelLegend7.Name = "labelLegend7";
            this.labelLegend7.Size = new System.Drawing.Size(10, 13);
            this.labelLegend7.TabIndex = 29;
            this.labelLegend7.Text = "-";
            // 
            // textBoxLegend6
            // 
            this.textBoxLegend6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.textBoxLegend6.Location = new System.Drawing.Point(3, 96);
            this.textBoxLegend6.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLegend6.Name = "textBoxLegend6";
            this.textBoxLegend6.Size = new System.Drawing.Size(20, 20);
            this.textBoxLegend6.TabIndex = 20;
            // 
            // labelLegend8
            // 
            this.labelLegend8.AutoSize = true;
            this.labelLegend8.Location = new System.Drawing.Point(26, 79);
            this.labelLegend8.Name = "labelLegend8";
            this.labelLegend8.Size = new System.Drawing.Size(10, 13);
            this.labelLegend8.TabIndex = 28;
            this.labelLegend8.Text = "-";
            // 
            // textBoxLegend5
            // 
            this.textBoxLegend5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.textBoxLegend5.Location = new System.Drawing.Point(3, 76);
            this.textBoxLegend5.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLegend5.Name = "textBoxLegend5";
            this.textBoxLegend5.Size = new System.Drawing.Size(20, 20);
            this.textBoxLegend5.TabIndex = 21;
            // 
            // labelLegend9
            // 
            this.labelLegend9.AutoSize = true;
            this.labelLegend9.Location = new System.Drawing.Point(26, 59);
            this.labelLegend9.Name = "labelLegend9";
            this.labelLegend9.Size = new System.Drawing.Size(10, 13);
            this.labelLegend9.TabIndex = 27;
            this.labelLegend9.Text = "-";
            // 
            // textBoxLegend9
            // 
            this.textBoxLegend9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.textBoxLegend9.Location = new System.Drawing.Point(3, 56);
            this.textBoxLegend9.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLegend9.Name = "textBoxLegend9";
            this.textBoxLegend9.Size = new System.Drawing.Size(20, 20);
            this.textBoxLegend9.TabIndex = 22;
            // 
            // labelLegend10
            // 
            this.labelLegend10.AutoSize = true;
            this.labelLegend10.Location = new System.Drawing.Point(26, 39);
            this.labelLegend10.Name = "labelLegend10";
            this.labelLegend10.Size = new System.Drawing.Size(10, 13);
            this.labelLegend10.TabIndex = 26;
            this.labelLegend10.Text = "-";
            // 
            // textBoxLegend10
            // 
            this.textBoxLegend10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.textBoxLegend10.Location = new System.Drawing.Point(3, 36);
            this.textBoxLegend10.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLegend10.Name = "textBoxLegend10";
            this.textBoxLegend10.Size = new System.Drawing.Size(20, 20);
            this.textBoxLegend10.TabIndex = 23;
            // 
            // labelLegend11
            // 
            this.labelLegend11.AutoSize = true;
            this.labelLegend11.Location = new System.Drawing.Point(26, 19);
            this.labelLegend11.Name = "labelLegend11";
            this.labelLegend11.Size = new System.Drawing.Size(10, 13);
            this.labelLegend11.TabIndex = 25;
            this.labelLegend11.Text = "-";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBoxShowMarkers);
            this.panel2.Controls.Add(this.checkBoxShowColors);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(303, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 24);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "Set";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 710);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSouth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWest)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPitch)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUpperBound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLowerBound)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStartLong;
        private System.Windows.Forms.TextBox textBoxStartLat;
        private System.Windows.Forms.NumericUpDown numericUpDownNorth;
        private System.Windows.Forms.NumericUpDown numericUpDownEast;
        private System.Windows.Forms.NumericUpDown numericUpDownSouth;
        private System.Windows.Forms.NumericUpDown numericUpDownWest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox checkBoxShowMarkers;
        private System.Windows.Forms.CheckBox checkBoxShowColors;
        private System.Windows.Forms.NumericUpDown numericUpDownPitch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownThreads;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxLegend11;
        private System.Windows.Forms.TextBox textBoxLegend10;
        private System.Windows.Forms.TextBox textBoxLegend9;
        private System.Windows.Forms.TextBox textBoxLegend5;
        private System.Windows.Forms.TextBox textBoxLegend6;
        private System.Windows.Forms.TextBox textBoxLegend7;
        private System.Windows.Forms.TextBox textBoxLegend8;
        private System.Windows.Forms.TextBox textBoxLegend4;
        private System.Windows.Forms.TextBox textBoxLegend3;
        private System.Windows.Forms.TextBox textBoxLegend2;
        private System.Windows.Forms.TextBox textBoxLegend1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelLegend1;
        private System.Windows.Forms.Label labelLegend2;
        private System.Windows.Forms.Label labelLegend3;
        private System.Windows.Forms.Label labelLegend4;
        private System.Windows.Forms.Label labelLegend5;
        private System.Windows.Forms.Label labelLegend6;
        private System.Windows.Forms.Label labelLegend7;
        private System.Windows.Forms.Label labelLegend8;
        private System.Windows.Forms.Label labelLegend9;
        private System.Windows.Forms.Label labelLegend10;
        private System.Windows.Forms.Label labelLegend11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackBarUpperBound;
        private System.Windows.Forms.TrackBar trackBarLowerBound;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxLowerBound;
        private System.Windows.Forms.TextBox textBoxUpperBound;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxUseBounds;
        private System.Windows.Forms.Button button3;
    }
}

