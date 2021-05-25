using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace basehub
{
    class BaseHubMap
    {
        public BaseHubMap()
        {

        }

        /// <summary>
        /// name of the map
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// memory path of saved map image<
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// location query from google static maps api
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// illustration type of the map
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// width in pixels from map in picture box<
        /// </summary>
        public int Width { get;  set; }

        /// <summary>
        /// height in pixels from map in picture box
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// zoom stage from google static maps api
        /// </summary>
        public int Zoom { get; set; }

        /// <summary>
        /// map scale from google static maps api
        /// </summary>
        public int Scale { get; set; }

        /// <summary>
        /// latitude coordinates of map center from google geocoding api
        /// </summary>
        public float coordsLat { get; set; }

        /// <summary>
        /// longitude coordinates of map center from google geocoding api
        /// </summary>
        public float coordLng { get; set; }

        /// <summary>
        /// pixel to degrees ration in x direction
        /// </summary>
        public float scaleX { get; set; }

        /// <summary>
        /// pixel to degrees ration in y direction
        /// </summary>
        public float scaleY { get; set; }

        /// <summary>
        /// calculates the pixel to degree ratios in both directions
        /// </summary>
        public void calcScale()
        {
            scaleX = 360 / ((Width/Scale) * (float)Math.Pow(2, Zoom));
            scaleY = 180 / ((Height/Scale) * (float)Math.Pow(2, Zoom));
        }

        /// <summary>
        /// maps a JObject to the class properties
        /// </summary>
        /// <param name="data"></param>
        public void ParseJObject(JObject data)
        {
            try
            {
                Name = data.Property("Name").Value.ToString();
                Path = data.Property("Path").Value.ToString();
                Query = data.Property("Query").Value.ToString();
                Type = data.Property("Type").Value.ToString();
                Width = (int)data.Property("Width").Value;
                Height = (int)data.Property("Height").Value;
                Zoom = (int)data.Property("Zoom").Value;
                Scale = (int)data.Property("Path").Value;
                coordsLat = (float)data.Property("Path").Value;
                coordLng = (float)data.Property("Path").Value;
                scaleX = (float)data.Property("Path").Value;
                scaleY = (float)data.Property("Path").Value;
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }
        /// <summary>
        /// returns the properties of BaseHubMap as JObject
        /// </summary>
        /// <returns></returns>
        public JObject GetJObject()
        {
            JObject mapData = new JObject();
            mapData = (JObject)JToken.FromObject(this);
            return mapData;
        }
    }
}
