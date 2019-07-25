using DFDS.Common;
using DFDS.DataAccess;
using DFDS.Models;
using System;
using System.Web.Http;

namespace DFDS.Controllers
{
    public class DistanceController : ApiController
    {
        [Route("api/truckplans/{id}/distance")]
        [HttpGet]
        public IHttpActionResult GetTruckPlanDistance(int id)
        {
            try
            {
                if(id == 0)
                {
                    return BadRequest($"Invalid id: {id}");
                }

                var dataAccess = new DataAccessHelper();
                var truckDal = dataAccess.GetTruckDal();

                var truckPlan = truckDal.GetTruckPlan(id);

                var totalDistanceMeters = DistanceUtil.GetTotalDistance(truckPlan.Route);

                return Ok(totalDistanceMeters);
            }
            catch (ArgumentException e)
            {
                //Log exception
                return BadRequest(e.Message);
            }
            catch (Exception)
            {
                //Log exception
                return InternalServerError();
            }

        }

        [Route("api/distance/{country}/{minAge}/{year}/{month}")]
        [HttpGet]
        public IHttpActionResult GetDistance(string country, int? minAge, int? year, int? month)
        {
            try
            {
                var dataAccess = new DataAccessHelper();
                var searchDal = dataAccess.GetSearchDal();

                var searchParams = new DistanceSearchParams
                {
                    MinAge = minAge,
                    Country = country,
                    Year = year,
                    Month = month
                };

                var result = searchDal.GetDistanceByParams(searchParams);

                return Ok(result);
            }
            catch (Exception e)
            {
                //Log exception
                return InternalServerError();
            }

        }
    }
}
