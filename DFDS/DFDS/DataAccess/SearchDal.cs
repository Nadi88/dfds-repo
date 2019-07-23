using DFDS.Interfaces;
using DFDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFDS.DataAccess
{
    public class SearchDal : ISearch
    {

        public double GetDistanceByParams(SearchParams searchParams)
        {
            //Running out of time :)
            //Assuming that we can query some db with the parameters in searchParams
            //By using a SearchParams object we can add parameters without changing the signature

            return 100;
        }
    }
}