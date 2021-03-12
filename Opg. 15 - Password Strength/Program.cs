using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Strength
{
    class Program
    {
        readonly static string[] response = { "very weak password.", "weak password.", "strong password", "very strong password" };
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a password.");
            string password = Console.ReadLine();
            int value = Password.passwordValidator(password);
            Console.WriteLine($"The password '{password}' is a {response[value]}");
        }
    }
}
