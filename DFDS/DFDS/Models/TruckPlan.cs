using System.Collections.Generic;

namespace DFDS.Models
{
    public class TruckPlan
    {
        public List<Coordinate> Route { get; set; }
        public double TotalRouteDistance { get; set; }
    }
}