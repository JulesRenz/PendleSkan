using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PendleSkan
{
    public class ProgConfig
    {
        public string apiKey = "";

        public GMap.NET.PointLatLng centerPos { get; set; }

        public ProgConfig() {
            centerPos = new GMap.NET.PointLatLng();
        }
    }
}
