using OPG42ParsingADataFile;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Singleton_Project
{
    class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;
        private static List<Data> clients = new List<Data>();
        public string[] data = File.ReadAllText("../../Data.csv").Split(new char[] { ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);


        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
        
        public void Run()
        {
            for (int i = 0; i < data.Length; i += 3)
            {
                clients.Add(new Data { lName = data[i], fName = data[i + 1], salary = Int32.Parse(data[i + 2]).ToString("C0", CultureInfo.CreateSpecificCulture("en-US")) });
            }

            //Sort the list
            clients.Sort(delegate (Data t1, Data t2) { return t2.salary.CompareTo(t1.salary); });
        }

        public void Display()
        {
            Console.WriteLine("{0,-9}{1,-9}{2,-10}", "Last", "First", "Salary");
            Console.WriteLine(new String('-', 25));

            foreach (Data client in clients)
            {
                Console.WriteLine("{0,-9}{1,-9}{2,-10}", client.lName, client.fName, client.salary);
            }
        }
    }
}
