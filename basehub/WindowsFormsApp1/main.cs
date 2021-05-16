﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Http;
using System.IO;
using Newtonsoft.Json.Linq;

namespace basehub
{
    public partial class main : Form
    {
        HttpClient httpClient = new HttpClient();


        public main()
        {            
            InitializeComponent();
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            string location = textBox_location.Text;
            string size;
            string scale = GetMapSize(pictureBox_map.Width, pictureBox_map.Height, 1, out size).ToString();
            string zoom = trackBar_mapZoom.Value.ToString();
            string apiKey = "AIzaSyC4BIZBnmh0nkMR2u7wtrk0eQtwublOG9c";
            string mapType = "hybrid";

            UriBuilder imageUri = new UriBuilder();
            imageUri.Scheme = "http";
            imageUri.Host = "maps.googleapis.com";
            imageUri.Path = "/maps/api/staticmap";
            imageUri.Query = $"center={location}&size={size}&scale={scale}&zoom={zoom}&maptype={mapType}&key={apiKey}";

            UriBuilder locationUri = new UriBuilder();
            locationUri.Scheme = "https";
            locationUri.Host = "maps.googleapis.com";
            locationUri.Path = "/maps/api/geocode/json";
            locationUri.Query = $"address={location}&key={apiKey}";

            /*
            var image = Image.FromStream(HttpGetStream(imageUri.Uri));
            pictureBox_map.Image = image;*/

            if (HttpGetString(locationUri.Uri,out string data))
            {
                JObject locationData = JObject.Parse(data);
                string latitude = (string)locationData["results"][0]["geometry"]["location"]["lat"];
                string longitude = (string)locationData["results"][0]["geometry"]["location"]["lng"];
            };
            
        }

        private void trackBar_MapZoom_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_mapSize.Value = trackBar_mapZoom.Value;
        }

        private void numericUpDown_MapSize_ValueChanged(object sender, EventArgs e)
        {
            trackBar_mapZoom.Value = (int)numericUpDown_mapSize.Value;
        }
        private void comboBox_MapType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button_Search.Enabled = true;
        }

        #region methods

        private bool HttpGetString(Uri uri, out string data)
        {
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(uri).Result;
                response.EnsureSuccessStatusCode();
                data = response.Content.ReadAsStringAsync().Result;
                return true;
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                data = "";
                return false;
            }
            
        }

        private Stream HttpGetStream(Uri uri)
        {
            Stream data = httpClient.GetStreamAsync(uri).Result;
            return data;
        }

        private int GetMapSize(int width, int height, int scale, out string size)
        {
            if (width>640 || height > 640)
            {
                scale = GetMapSize(width / 2, height / 2, scale + 1, out size);
            }
            else
            {                
                size = $"{width}x{height}";                
            }
            return scale;
        }

        #endregion

        
    }
}


