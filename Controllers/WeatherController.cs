using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Weather_Services.Models;
using Weather_Services.WeatherServices;

namespace Weather_Services.Controllers
{
    [Route("api/")]
    [ApiController]
    public class WeatherController : ControllerBase
    {

        private readonly IWeatherServices _weatherServices;

        public WeatherController(IWeatherServices weatherServices)
        {
            _weatherServices = weatherServices;
        }

      
        // GET api/GetWeather/lat=""&lon="";
        [HttpGet]
        [Route("getweather/lat={lat}&lon={lon}")]
        public ActionResult <Dictionary<string, WeatherDetails>> Get(double lat, double lon) 
        {
          
            var weather = _weatherServices.GetWeatherDetails(lat,lon);
            if (weather.Count == 0)
            {
                return NotFound();
            }
            return weather;
        }
    }
}
