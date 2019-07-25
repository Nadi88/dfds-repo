using DFDS.Interfaces;
using DFDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFDS.DataAccess
{
    public class TruckDal : ITruckPlan
    {
        public TruckPlan GetTruckPlan(int id)
        {
            //Assuming we will get the truckplan from a db somewhere
            //Will just return mock data 

            var dateTime = new DateTime(2019, 07, 20);
            TimeSpan time = new TimeSpan(06, 00, 0);
            dateTime += time;

            TimeSpan fiveMin = new TimeSpan(00, 05, 0);

            var truckPlan = new TruckPlan
            {
                Route = new List<Coordinate>
                {
                    new Coordinate(54.325069, 10.111896, dateTime),
                    new Coordinate(54.299494, 10.087859, dateTime + fiveMin),
                    new Coordinate(54.284111, 10.051680, dateTime + fiveMin),
                    new Coordinate(54.260793, 10.038815, dateTime + fiveMin),
                    new Coordinate(54.255152, 9.974580, dateTime + fiveMin)
                }
            };

            return truckPlan;
        }

    }
}