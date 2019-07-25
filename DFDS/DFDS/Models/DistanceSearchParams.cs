using System;

namespace DFDS.Models
{
    public class DistanceSearchParams
    {
        public string Country { get; set; }
        public int? MinAge { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
    }
}