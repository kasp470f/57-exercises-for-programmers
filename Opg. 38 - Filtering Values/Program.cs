using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Filtering_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../numbers.txt";
            List<int> numbers = new List<int>();
            if (File.Exists(path)) numbers = new List<int>(File.ReadAllLines(path).Select(Int32.Parse));
            else Console.WriteLine($"File \'numbers.txt\' not found!");


            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
