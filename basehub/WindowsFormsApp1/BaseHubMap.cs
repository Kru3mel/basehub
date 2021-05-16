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

        public string mapName { get; set; }

        public string mapLocation { get; set; }

        public string mapType { get; set; }

        public int mapWidth { get;  set; }

        public int mapHeight { get; set; }

        public float coordsLat { get; set; }

        public float coordLng { get; set; }

        public int mapZoom { get; set; }

        public int mapScale { get; set; }

        public float scaleX { get; set; }

        public float scaleY { get; set; }

        public void calcScales()
        {
            scaleX = 360 / ((mapWidth/mapScale) * (float)Math.Pow(2, mapZoom));
            scaleY = 180 / ((mapHeight / mapScale) * (float)Math.Pow(2, mapZoom));
        }
    }
}
