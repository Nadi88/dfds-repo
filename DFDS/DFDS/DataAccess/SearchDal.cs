using DFDS.Interfaces;
using DFDS.Models;

namespace DFDS.DataAccess
{
    public class SearchDal : ISearch
    {

        public double GetDistanceByParams(DistanceSearchParams searchParams)
        {
            //Running out of time :)
            //Assuming that we can query some db with the parameters in searchParams
            //By using a SearchParams object we can add parameters without changing the signature

            return 100;
        }
    }
}