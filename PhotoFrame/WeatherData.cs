using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFrame
{
    public class WeatherData
    {
        string description = String.Empty;
        string iconUrl = String.Empty;
        string temp = String.Empty;
        string pressure = String.Empty;
        string humidity = String.Empty;
        string tempMin = String.Empty;
        string tempMax = String.Empty;
        string windSpeed = "0";

        public string Description
        {
            get
            {
                return description.ToUpper();
            }
            set
            {
                description = value;
            }
        }
        public string IconUrl
        {
            get
            {
                return "http://openweathermap.org/img/w/" + iconUrl + ".png";
            }
            set
            {
                iconUrl = value;
            }
        }
        public string Temp
        {
            get
            {
                double _temp = double.Parse(temp.Replace(".", ","));
                int __temp = (int)Math.Round(_temp);
                return __temp.ToString() + "°C";
            }
            set
            {
                temp = value;
            }
        }
        public string Pressure
        {
            get
            {
                return pressure + "hPa";
            }
            set
            {
                pressure = value;
            }
        }
        public string Humidity
        {
            get
            {
                return humidity + "%";
            }
            set
            {
                humidity = value;
            }
        }

        public string TempMin
        {
            get
            {
                return tempMin + "°C";
            }
            set
            {
                tempMin = value;
            }
        }
        public string TempMax
        {
            get
            {
                return tempMax + "°C";
            }
            set
            {
                tempMax = value;
            }
        }
        public string WindSpeed
        {
            get
            {
                return windSpeed + "km/h";
            }
            set
            {
                windSpeed = value;
            }
        }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }


        public void PopulateProperties(string jsonString)
        {
            dynamic data = JObject.Parse(jsonString);
            Description = (string)data["weather"][0]["description"];
            IconUrl = (string)data["weather"][0]["icon"];
            Temp = (string)data["main"]["temp"];
            Pressure = (string)data["main"]["pressure"];
            Humidity = (string)data["main"]["humidity"];
            TempMin = (string)data["main"]["temp_min"];
            TempMax = (string)data["main"]["temp_max"];
            WindSpeed = (string)data["main"]["wind"];
        }
    }

}
