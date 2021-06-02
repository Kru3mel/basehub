using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Globalization;

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
        public double Latitude { get; set; }

        /// <summary>
        /// longitude coordinates of map center from google geocoding api
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// pixel to degrees ration in x direction
        /// </summary>
        public double ScaleX { get; set; }

        /// <summary>
        /// pixel to degrees ration in y direction
        /// </summary>
        public double ScaleY { get; set; }

        /// <summary>
        /// calculates the pixel to degree ratios in both directions
        /// </summary>
        public void calcScale()
        {
            ScaleX = 360 / ((Width/Scale) * Math.Pow(2, Zoom));
            ScaleY = 180 / ((Height/Scale) * Math.Pow(2, Zoom));
        }

        /// <summary>
        /// maps a JObject to the class properties
        /// </summary>
        /// <param name="data"></param>
        public void ParseJObject(JObject data)
        {
            try
            {
                Name = data["Name"].ToString();
                Path = data["Path"].ToString();
                Query = data["Query"].ToString();
                Type = data["Type"].ToString();
                Width = (int)data["Width"];
                Height = (int)data["Height"];
                Zoom = (int)data["Zoom"];
                Scale = (int)data["Scale"];

                Latitude = (double)data["Latitude"];
                Longitude = (double)data["Longitude"];
                ScaleX = (double)data["ScaleX"];
                ScaleY = (double)data["ScaleY"];
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
