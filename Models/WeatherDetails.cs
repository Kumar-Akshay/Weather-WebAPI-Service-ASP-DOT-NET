using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weather_Services.Models
{
    public class WeatherDetails
    {
        public string your_IP { get; set; }
        public string IP_City { get; set; }
        public string City_From_latitude_longitute { get; set; }
        public string country { get; set; }
        public double latitude { get; set; }
        public double longitute { get; set; }
        public double temprature { get; set; }
        public double pressure { get; set; }
        public double humidity { get; set; }
        public double feels_like { get; set; }
        public double wind { get; set; }
        public string Cloudiness { get; set; }
            
    }
}
