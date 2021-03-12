using System;

namespace Grabbing_the_Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Where are you?\t");
            string city = Console.ReadLine();

            string temperature = API.WeatherAPI(city) + "°C";
            if (temperature != "NaN°C")
            {
                Console.WriteLine("{0} weather", city);
                Console.WriteLine(temperature);
            }
            else
            {
                Console.WriteLine("Could not find a city with that name!");
            }
        }
    }
}
