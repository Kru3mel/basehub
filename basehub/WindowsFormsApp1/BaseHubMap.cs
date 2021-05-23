using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basehub
{
    class BaseHubMap
    {
        public BaseHubMap()
        {

        }

        public string Name { get; set; }

        public string Path { get; set; }

        public string Query { get; set; }

        public string Type { get; set; }

        public int Width { get;  set; }

        public int Height { get; set; }

        public int Zoom { get; set; }

        public int Scale { get; set; }

        public float coordsLat { get; set; }

        public float coordLng { get; set; }

        public float scaleX { get; set; }

        public float scaleY { get; set; }

        public void calcScale()
        {
            scaleX = 360 / ((Width/Scale) * (float)Math.Pow(2, Zoom));
            scaleY = 180 / ((Height/Scale) * (float)Math.Pow(2, Zoom));
        }
    }
}
