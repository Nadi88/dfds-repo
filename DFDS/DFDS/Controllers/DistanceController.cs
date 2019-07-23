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
                    return BadRequest($"Invalid id {id}");
                }

                var dataAccess = new DataAccessHelper();
                var truckDal = dataAccess.GetTruckDal();

                var truckPlan = truckDal.GetTruckPlan(id);

                var totalDistanceMeters = DistanceUtil.GetTotalDistance(truckPlan.Route);

                return Ok(totalDistanceMeters);
            }
            catch (Exception)
            {
                //Log exception
                return InternalServerError();
            }

        }

        //Implement functionality for answering the following question: 
        //    "How many kilometers did drivers over the age of 50 drive in Germany in February 2018?" 

        [Route("api/distance")]
        [HttpGet]
        public IHttpActionResult GetDistance(int? minAge, string country, DateTime? date)
        {
            try
            {
                var dataAccess = new DataAccessHelper();
                var searchDal = dataAccess.GetSearchDal();

                var searchParams = new SearchParams
                {
                    MinAge = minAge,
                    Country = country,
                    DateTime = date
                };

                var result = searchDal.GetDistanceByParams(searchParams);

                return Ok(result);
            }
            catch (Exception)
            {
                //Log exception
                return InternalServerError();
            }

        }
    }
}
