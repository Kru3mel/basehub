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

        }

        public Telemetry(string name,double latitude,double longitude, int height, int velocity, string heading, int battery)
        {
            this.Name = name;
            this.Longitude = longitude;
            this.Longitude = latitude;
            this.Height = height;
            this.Velocity = velocity;
            this.Heading = heading;
            this.Battery = battery;
        }

        public string Name { set; get; }

        public double Latitude { set; get; }

        public double Longitude { set; get; }

        public int Height { set; get; }

        public int Velocity { set; get;}

        public string Heading { set; get; }

        public int Battery { set; get; }
    }
}
