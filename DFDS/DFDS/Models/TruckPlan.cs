using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFDS.Models
{
    public class TruckPlan
    {
        public List<Coordinate> Route { get; set; }
        public double TotalRouteDistance { get; set; }
    }
}