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

        public string Name { set; get; }

        public DateTime Time { set; get; }

        public double Latitude { set; get; }

        public double Longitude { set; get; }

        public int Height { set; get; }

        public int Velocity { set; get;}

        public string Heading { set; get; }

        public int Battery { set; get; }
    }
}
