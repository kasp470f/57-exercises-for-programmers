using System;
using System.IO;
using System.Net;

namespace Grabbing_the_Weather
{
    public class API
    {
        public static double WeatherAPI(string city)
        {
            try
            {
                string apikey = File.ReadAllText("../../APIKey.txt");
                string weather = APIProcess($"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={apikey}");
                var temp = weather.Substring(weather.IndexOf("temp")).Split(',')[0].Split(':')[1];
                double temperature = double.Parse(temp);
                return Math.Round(temperature);
            }
            catch (Exception)
            {
                return double.NaN;
            }

        }

        static dynamic APIProcess(string url)
        {
            var webRequest = WebRequest.Create(string.Format(@"{0}", url));

            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                return reader.ReadToEnd();
            }
        }
    }

}
