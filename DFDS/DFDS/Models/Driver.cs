using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFDS.Models
{
    public class Driver
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DayOfBirth { get; set; }


        public int GetAge()
        {
            var age = DateTime.Now.Year - DayOfBirth.Year;
            return age;
        }
    }
}