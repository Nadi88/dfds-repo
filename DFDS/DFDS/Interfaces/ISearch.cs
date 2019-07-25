using DFDS.Models;

namespace DFDS.Interfaces
{
    public interface ISearch
    {
        double GetDistanceByParams(DistanceSearchParams searchParams);
    }
}
