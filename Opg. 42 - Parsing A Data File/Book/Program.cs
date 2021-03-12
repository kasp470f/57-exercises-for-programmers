using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace OPG42ParsingADataFile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Data> clients = new List<Data>();
            string[] data = File.ReadAllText("../../Book/Data.csv").Split(new char[] { ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < data.Length; i += 3)
            {
                clients.Add(new Data { lName = data[i], fName = data[i+1], salary = Int32.Parse(data[i+2]).ToString("C0", CultureInfo.CreateSpecificCulture("en-US")) });
            }

            // Header
            Console.WriteLine("{0,-9}{1,-9}{2,-10}", "Last", "First", "Salary");
            Console.WriteLine(new String('-', 25));

            //Sort the list
            clients.Sort(delegate (Data t1, Data t2)
            { return (t2.salary.CompareTo(t1.salary)); }
            );

            foreach (Data client in clients)
            {
                Console.WriteLine("{0,-9}{1,-9}{2,-10}", client.lName, client.fName, client.salary);
            }
        }
    }
}
