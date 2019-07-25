using DFDS.Interfaces;

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