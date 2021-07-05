using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basehub
{
    public class Telemetry
    {
        public Telemetry()
        {
            this.Time = DateTime.Now;
            this.Longitude = 0;
            this.Latitude = 0;
            this.Height = -1;
            this.Velocity = -1;
            this.Heading = "unknown";
            this.Battery = -1;
        }

        /// <summary>
        /// name of UAS
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// timestamp of received telemetry
        /// </summary>
        public DateTime Time { set; get; }

        /// <summary>
        /// latitude coordinates of UAS
        /// </summary>
        public double Latitude { set; get; }

        /// <summary>
        /// longitude coordinates of UAS
        /// </summary>
        public double Longitude { set; get; }

        /// <summary>
        /// height of UAS
        /// </summary>
        public int Height { set; get; }

        /// <summary>
        /// velocity of UAS
        /// </summary>
        public int Velocity { set; get;}

        /// <summary>
        /// heading of UAS
        /// </summary>
        public string Heading { set; get; }

        /// <summary>
        /// battery level of UAS
        /// </summary>
        public int Battery { set; get; }
    }
}
