using DFDS.DataAccess;
using System;
using System.Web.Http;

namespace DFDS.Controllers
{
    public class LocationController : ApiController
    {
        [Route("api/countries/{latitude}/{longitude}")]
        [HttpGet]
        public IHttpActionResult GetCountry(double latitude, double longitude)
        {
            try
            {
                if (latitude == 0 || longitude == 0)
                {
                    return BadRequest($"Invalid latitude and longitude {latitude}, {longitude}");
                }

                var dalHelper = new DataAccessHelper();
                var dataAccess = dalHelper.GetLocationDal();

                var country = dataAccess.GetCountry(latitude, longitude);

                if(country == null)
                {
                    return NotFound();
                }

                return Ok(country);
            }
            catch (Exception)
            {
                //Log exception
                //Return appripriate error message
                return InternalServerError();
            }

        }
    }
}
