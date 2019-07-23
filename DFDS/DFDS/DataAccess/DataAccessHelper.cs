using DFDS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFDS.DataAccess
{
    public class DataAccessHelper
    {
        public ILocation GetLocationDal()
        {
            return new OpenCageDal();
        }

        public ITruckPlan GetTruckDal()
        {
            return new TruckDal();
        }

        public ISearch GetSearchDal()
        {
            return new SearchDal();
        }
    }
}