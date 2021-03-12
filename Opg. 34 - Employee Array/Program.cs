using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueRemoval = true;
            do
            {
                Employee();
                Console.WriteLine("Press enter to stop removing names");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.Escape) continueRemoval = false;
                Console.Clear();
            } while (continueRemoval);
        }

        static void Employee()
        {
            string path = "../../employees.txt";
            List<string> Employees = new List<string>();
            if (File.Exists(path))
            {
                Employees = new List<string>(File.ReadAllLines(path));
            }

            Console.WriteLine($"There are {Employees.Count} employees:\n" + string.Join("\n", Employees));

            Console.Write("Enter an employee name to remove: ");
            string removeName = Console.ReadLine();
            try
            {
                Employees.Remove(removeName);
            }
            catch (Exception)
            {
                Console.WriteLine("Name was not found and therefore could not be removed.");
            }
            File.WriteAllLines(path, Employees);
            Console.WriteLine($"There are {Employees.Count} employees:\n" + string.Join("\n", Employees));
        }
    }
}
