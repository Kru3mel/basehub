using System;
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
        BaseHubMap map = new BaseHubMap();

        public main()
        {            
            InitializeComponent();
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            //Set the required values for the API Requests
            map.mapLocation = textBox_location.Text;
            map.mapWidth = pictureBox_map.Width;
            map.mapHeight = pictureBox_map.Height;

            map.mapZoom = trackBar_mapZoom.Value;

            string size;
            map.mapScale = GetMapSize(pictureBox_map.Width, pictureBox_map.Height, 1, out size);
            map.mapType = comboBox_mapType.Text;

            string apiKey = "AIzaSyC4BIZBnmh0nkMR2u7wtrk0eQtwublOG9c";

            //Build Google Maps Static API Request
            UriBuilder imageUri = new UriBuilder();
            imageUri.Scheme = "http";
            imageUri.Host = "maps.googleapis.com";
            imageUri.Path = "/maps/api/staticmap";
            imageUri.Query = $"center={map.mapLocation}&size={size}&scale={map.mapScale}&zoom={map.mapZoom}&maptype={map.mapType}&key={apiKey}";

            //Build Google Maps Geocoding API Request
            UriBuilder locationUri = new UriBuilder();
            locationUri.Scheme = "https";
            locationUri.Host = "maps.googleapis.com";
            locationUri.Path = "/maps/api/geocode/json";
            locationUri.Query = $"address={map.mapLocation}&key={apiKey}";

            //Download the desired map from google maps and display it in picture box
            var image = Image.FromStream(HttpGetStream(imageUri.Uri));
            pictureBox_map.Image = image;

            //Get the corresponding coordinates from the center of the map using the same query
            if (HttpGetString(locationUri.Uri,out string data))
            {
                JObject locationData = JObject.Parse(data);
                map.coordsLat = (float)locationData["results"][0]["geometry"]["location"]["lat"];
                map.coordLng = (float)locationData["results"][0]["geometry"]["location"]["lng"];
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
            button_search.Enabled = true;
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

        private void textBox_location_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter && button_search.Enabled == true)
            {
                Button_Search_Click(sender, e);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            //Open and configure a Save File Dialog to get the file path
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.AddExtension = true;

            saveFileDialog.Filter = "Images|*.png";
            saveFileDialog.FileName = map.mapLocation;
            saveFileDialog.DefaultExt = "png";
            saveFileDialog.Title = "Save Map";

            saveFileDialog.FileName = map.mapLocation;

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                FileStream stream = File.Create(path);
                pictureBox_map.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                stream.Close();
            }

        }

        private void button_load_Click(object sender, EventArgs e)
        {
            //Open and configure a Load File Dialog to get the file from a path
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;

            openFileDialog.Filter = "Images|*.png";
            openFileDialog.DefaultExt = "png";
            openFileDialog.Title = "Open Map";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {                
                FileStream fileStream = File.OpenRead(openFileDialog.FileName);
                Image image = Image.FromStream(fileStream);
                pictureBox_map.Image = image;
            }
        }
    }
}


