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
using Newtonsoft.Json;

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
            catch (Exception e)
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
            if (width > 640 || height > 640)
            {
                scale = GetMapSize(width / 2, height / 2, scale + 1, out size);
            }
            else
            {
                size = $"{width}x{height}";
            }
            //maximum available Scale of Google Maps Static API is 2 
            if (scale > 2)
            {
                scale = 2;
            }
            return scale;
        }

        private bool SaveMapData(BaseHubMap map, string path)
        {
            if (File.Exists(path))
            {
                //Create new JObjcet
                JObject mapData;

                //Load the Map Data from File into JObject
                using (StreamReader file = File.OpenText(path))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    mapData = (JObject)JToken.ReadFrom(reader);

                }

                //add newMapData to mapData
                mapData.Add($"map_{mapData.Count}", map.GetJObject());

                //save mapData to File
                SaveJobjectToFile(mapData, path);

                return true;
            }
            else
            {
                //Check of the Directory to save to exists
                if (!Directory.Exists(Path.GetDirectoryName(path)))
                {
                    //Try to create the non existing Directory
                    try
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(path));
                    }
                    catch
                    {
                        MessageBox.Show("Coudn't create path to save Map Data");
                        return false;
                    }
                }

                //Create new JObject to parse MapData into
                JObject mapData = new JObject();


                //Add mapDataClass as first children of mapIndex
                mapData.Add("map_0", map.GetJObject());

                //save mapData to File
                SaveJobjectToFile(mapData, path);
                return true;
            }
        }

        private void SaveJobjectToFile(JObject data, string path)
        {
            using (StreamWriter file = File.CreateText(path))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                data.WriteTo(writer);
            }
        }

        private void DevTestBench()
        {
            textBox_location.Text = "Eilenburg";
            comboBox_mapType.Text = "hybrid";
            button_search.Enabled = true;
            button_search.PerformClick();
            button_save.PerformClick();
        }


        #endregion

        private void Button_Search_Click(object sender, EventArgs e)
        {
            //Set the required values for the API Requests
            map.Query = textBox_location.Text;
            map.Width = pictureBox_map.Width;
            map.Height = pictureBox_map.Height;

            map.Zoom = trackBar_mapZoom.Value;

            string size;
            map.Scale = GetMapSize(pictureBox_map.Width, pictureBox_map.Height, 1, out size);
            map.Type = comboBox_mapType.Text;
            map.calcScale();

            string apiKey = "AIzaSyC4BIZBnmh0nkMR2u7wtrk0eQtwublOG9c";

            //Build Google Maps Static API Request
            UriBuilder imageUri = new UriBuilder();
            imageUri.Scheme = "http";
            imageUri.Host = "maps.googleapis.com";
            imageUri.Path = "/maps/api/staticmap";
            imageUri.Query = $"center={map.Query}&size={size}&scale={map.Scale}&zoom={map.Zoom}&maptype={map.Type}&key={apiKey}";

            //Build Google Maps Geocoding API Request
            UriBuilder locationUri = new UriBuilder();
            locationUri.Scheme = "https";
            locationUri.Host = "maps.googleapis.com";
            locationUri.Path = "/maps/api/geocode/json";
            locationUri.Query = $"address={map.Query}&key={apiKey}";

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
            saveFileDialog.FileName = map.Name;
            saveFileDialog.DefaultExt = "png";
            saveFileDialog.Title = "Save Map";

            saveFileDialog.FileName = map.Query;

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                FileStream stream = File.Create(path);
                pictureBox_map.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                map.Path = stream.Name;
                map.Name = Path.GetFileName(stream.Name);
                stream.Close();
            }

            SaveMapData(map, "C:\\MapData\\map.json");

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
                //Open File into FileStream from path
                FileStream fileStream = File.OpenRead(openFileDialog.FileName);

                map.Path = openFileDialog.FileName;
                map.Name = Path.GetFileName(map.Path);

                Image image = Image.FromStream(fileStream);
                pictureBox_map.Image = image;
            }
        }

        private void main_Shown(object sender, EventArgs e)
        {
            DevTestBench();
        }
    }
}


