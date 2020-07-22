using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weather_Services.Models;

namespace Weather_Services.WeatherServices
{
    public interface IWeatherServices
    {
        Dictionary<string, WeatherDetails> GetWeatherDetails(double lat, double lon);
    }
}
