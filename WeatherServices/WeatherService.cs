using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Weather_Services.Models;
using Weather_Services.WeatherServices;

namespace Weather_Services.WeatherServices
{
    public class WeatherService : IWeatherServices
    {
        private readonly Dictionary<string, WeatherDetails> _weather;

        private string url1;
        private string url2;
        private string CityName;
        private string YourIP;
        private WeatherDetails weather = new WeatherDetails();


        public WeatherService()
        {
            _weather = new Dictionary<string, WeatherDetails>();
            //Fetcing City Name Based on IP
            url1 = "http://api.ipinfodb.com/v3/ip-city/?key=b7d840505f6bc036c504b5c3fa2589468a8172f8318d664952cf83797a5e8251&format=json";
            var City_API_Details = new WebClient().DownloadString(url1);
            dynamic City_IP_jsonobject = JObject.Parse(City_API_Details);
            CityName = City_IP_jsonobject.cityName;
            YourIP = City_IP_jsonobject.ipAddress;
        }
        
        public Dictionary<string, WeatherDetails> GetWeatherDetails(double lat, double lon)
        {
            //Fetching Weather Details 
            url2 = String.Format("http://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&units=metric&lang=en&appid=4b9be5067751c7c24283cf32d28bc06b", lat, lon);
            var Weather_API_Details = new WebClient().DownloadString(url2);
            dynamic Weather_API_Json = JObject.Parse(Weather_API_Details);
       
            weather.your_IP = YourIP;
            weather.IP_City = CityName;
            weather.City_From_latitude_longitute = Weather_API_Json.name;
            weather.country = Weather_API_Json.sys.country;
            weather.latitude = Weather_API_Json.coord.lat;
            weather.longitute = Weather_API_Json.coord.lon;
            weather.temprature = Weather_API_Json.main.temp;
            weather.pressure = Weather_API_Json.main.pressure;
            weather.humidity = Weather_API_Json.main.humidity;
            weather.wind = Weather_API_Json.wind.speed;
            weather.Cloudiness = Weather_API_Json.weather[0].description;
            weather.feels_like = Weather_API_Json.main.feels_like;
            
            _weather.Add(weather.City_From_latitude_longitute, weather);

            return _weather;



        }


    }
}



