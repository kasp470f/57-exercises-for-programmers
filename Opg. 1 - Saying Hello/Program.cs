using System;

namespace Saying_Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            string response = $"Hello, {name}, nice to meet you!";
            Console.WriteLine(response);
        }
    }
}
