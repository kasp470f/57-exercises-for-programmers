using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Lib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a noun: ");
            string noun = Console.ReadLine();
            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();
            Console.Write("Enter a adjective: ");
            string adjective = Console.ReadLine();
            Console.Write("Enter a adverb: ");
            string adverb = Console.ReadLine();

            Console.WriteLine($"Do you {verb} your {adjective} {noun} {adverb}? That\'s hilarious!");
        }
    }
}
