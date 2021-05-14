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
            string location = TextBox_Location.Text;
            string size = "640x640";
            string scale = "1";
            string zoom = "14";
            string apiKey = "AIzaSyC4BIZBnmh0nkMR2u7wtrk0eQtwublOG9c";
            string mapType = "hybrid";

            UriBuilder uriBuilder = new UriBuilder();
            uriBuilder.Scheme = "http";
            uriBuilder.Host = "maps.googleapis.com";
            uriBuilder.Path = "/maps/api/staticmap";
            uriBuilder.Query = $"center={location}&size={size}&scale={scale}&zoom={zoom}&maptype={mapType}&key={apiKey}";

            var image = Image.FromStream(HttpGetStream(uriBuilder.Uri));
            pictureBox_Map.Image = image;
        }

        #region methods
        /*
        private string HttpGet(Uri uri)
        {


            return data;
        }*/     

        private Stream HttpGetStream(Uri uri)
        {
            Stream data = httpClient.GetStreamAsync(uri).Result;
            return data;
        }     

        #endregion

    }
}


