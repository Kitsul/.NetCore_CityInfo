using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        /// GET api/cities
        /// <summary>
        /// Get all cities from API
        /// </summary>
        /// <returns></returns>
        /// /// ### REMARKS ###
        /// The following codes are returned
        /// - 200 - Updated an existing API object
        [HttpGet()]
        public IActionResult GetCities()
        {
            var citiesResponse = new JsonResult(CitiesDataStore.Current.Cities);
            citiesResponse.StatusCode = 200;
            return citiesResponse;
        }

        /// <summary>
        /// Creates a TodoItem.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     {
        ///        "id": 1,
        ///        "name": "Item1",
        ///        "isComplete": true
        ///     }
        ///
        /// </remarks>
        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);

            if (cityToReturn == null) return NotFound();

            return Ok(cityToReturn);
        }
    }
}
