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
        
        //name of the map
        public string Name { get; set; }

        //memory location of save map image 
        public string Path { get; set; }

        //location query from google static maps api
        public string Query { get; set; }

        //type of the map
        public string Type { get; set; }

        //width in pixels from map in picture box
        public int Width { get;  set; }

        //height in pixels from map in picture box
        public int Height { get; set; }

        //zoom stage from google static maps api
        public int Zoom { get; set; }

        //map scale from google static maps api
        public int Scale { get; set; }

        //latitude coordinates of map center from google geocoding api
        public float coordsLat { get; set; }

        //longitude coordinates of map center from google geocoding api
        public float coordLng { get; set; }

        //pixel to degrees ration in x direction
        public float scaleX { get; set; }

        //pixel to degrees ration in y direction
        public float scaleY { get; set; }

        //calculates the pixel to degree ratios in both directions
        public void calcScale()
        {
            scaleX = 360 / ((Width/Scale) * (float)Math.Pow(2, Zoom));
            scaleY = 180 / ((Height/Scale) * (float)Math.Pow(2, Zoom));
        }

        //maps a JObject to the class properties
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
    }
}
