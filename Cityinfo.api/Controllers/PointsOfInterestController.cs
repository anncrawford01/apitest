using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cityinfo.api.Controllers
{
    [Route("api/cities")]
    public class PointsOfInterestController : Controller
    {
        [HttpGet("{cityid}/pointsofinterest")]

        public IActionResult GetPointsOfInterset(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null)
            {
                return NotFound();
             }

            return Ok(city.PointsOfInterest);
                
        }

        [HttpGet("{cityid}/pointsofinterest/{id}")]

        public IActionResult GetPointOfInterset(int cityId, int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }

            var pi = city.PointsOfInterest.FirstOrDefault(p => p.Id == id);
            if (pi == null)
            {
                return NotFound();
            }

            return Ok(pi);
            
        }

    }
}
