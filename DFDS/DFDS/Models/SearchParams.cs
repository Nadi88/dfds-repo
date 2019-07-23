using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFDS.Models
{
    public class SearchParams
    {
        public int? MinAge { get; set; }
        public string Country { get; set; }
        public DateTime? DateTime { get; set; }
    }
}