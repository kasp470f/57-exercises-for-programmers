using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg._35___Picking_a_Winner
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] names = new string[100]; // Initialize the Array
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter a name:");
                names[i] = Console.ReadLine();
                if (names[i] == "")
                {
                    names = names.Where(x => !string.IsNullOrEmpty(x)).ToArray(); // Remove the empty entries
                    Console.WriteLine("The winner is... {0}", names[random.Next(0, i)]);
                    break;
                }
            }
        }
    }
}
