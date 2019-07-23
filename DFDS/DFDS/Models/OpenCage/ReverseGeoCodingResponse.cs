using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFDS.Models.OpenCage
{
    public class Components
    {
       
    public string _type { get; set; }
    public string city { get; set; }
    public string city_district { get; set; }
    public string continent { get; set; }
    public string country { get; set; }
    public string country_code { get; set; }
    public string county { get; set; }
    public string house_number { get; set; }
    public string neighbourhood { get; set; }
    public string political_union { get; set; }
    public string postcode { get; set; }
    public string road { get; set; }
    public string state { get; set; }
    public string state_code { get; set; }
    public string state_district { get; set; }
    public string suburb { get; set; }
    }

    public class Geometry
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

    public class Result
    {
        public Components components { get; set; }
        public int confidence { get; set; }
        public string formatted { get; set; }
        public Geometry geometry { get; set; }
    }

    public class Status
    {
        public int code { get; set; }
        public string message { get; set; }
    }

    public class ReverseGeoCodingResponse
    {
        public List<Result> results { get; set; }
        public Status status { get; set; }
        public int total_results { get; set; }
    }

}