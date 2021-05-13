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
            string apiKey = "AIzaSyAqM1CnlEfs669Rig4zOzec48UusxS_hhI";
            string mapType = "roadmap";

            UriBuilder uriBuilder = new UriBuilder();
            uriBuilder.Scheme = "http";
            uriBuilder.Host = "maps.googleapis.com";
            uriBuilder.Path = "/maps/api/staticmap";
            uriBuilder.Query = $"center={location}&size={size}&scale={scale}&zoom={zoom}&maptype={mapType}&key={apiKey}";

            var image = Image.FromStream(HttpGetBytes(uriBuilder.Uri));
            pictureBox_Map.Image = image;
        }

        #region methods
        /*
        private string HttpGet(Uri uri)
        {


            return data;
        }*/     

        private Stream HttpGetBytes(Uri uri)
        {
            byte[] byte_data = httpClient.GetByteArrayAsync(uri).Result;
            Stream data = new MemoryStream(byte_data);
            return data;
        }     

        #endregion

    }
}


