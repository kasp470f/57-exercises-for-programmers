using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;


namespace Opg._47___Who_s_in_Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string Crew = API("http://api.open-notify.org/astros.json"); // Call Method
            dynamic json = JObject.Parse(Crew); // Parse it as JSON Object


            List<WhosInSpace> spacePeople = new List<WhosInSpace>();
            for (int i = 0; i < json.people.Count; i++)
            {
                spacePeople.Add(new WhosInSpace { name = json.people[i].name, craft = json.people[i].craft }); // Create new additions to the list 
            }


            Console.WriteLine($"{"Name",-20} | {"Craft",0}");
            Console.WriteLine("{0}|{1}", new String('-', 21), new String('-', 8));
            foreach (WhosInSpace person in spacePeople)
            {
                Console.WriteLine("{0,-20} | {1,0}", person.name, person.craft);
            }
            Console.WriteLine();
        }

        static dynamic API(string url) // Read API to string to later parse it as JSON
        {
            var webRequest = WebRequest.Create(@$"{url}");

            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                return reader.ReadToEnd();
            }
        }
    }

    public class WhosInSpace // Class for the list
    {
        public string name;
        public string craft;
    }
}
