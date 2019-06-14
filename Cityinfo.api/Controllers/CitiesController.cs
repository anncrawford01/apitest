using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cityinfo.api.Controllers
{

    [Route("api/cities")]
    public class CitiesController : Controller
    {
   
        [HttpGet()]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
            //return new JsonResult(new List<object>()
            //{
            //    new { id=1, Name = "New York City"},
            //    new { id = 2, Name = "Antwerp"}
            //});
         }

        [HttpGet("{id}")]   
        public IActionResult GetCity(int id)
        {
            var citytoReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (citytoReturn == null)
            {
                return NotFound();
            }

            return Ok(citytoReturn);

            //return new JsonResult (
            //    CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id)
            //    );
        }
    }
}
