using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFDS.Models
{
    public class Coordinate
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime DateTime { get; set; }

        public Coordinate(double latitude, double longitude, DateTime dateTime)
        {
            Latitude = latitude;
            Longitude = longitude;
            DateTime = dateTime;
        }
    }
}