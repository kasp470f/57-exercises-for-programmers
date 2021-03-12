using System;

namespace Simple_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;

            string temp = "";
            while (!int.TryParse(temp, out _))
            {
                Console.Write("What is the first number? ");
                temp = Console.ReadLine();
            }
            first = int.Parse(temp);

            temp = "";
            while (!int.TryParse(temp, out _))
            {
                Console.Write("What is the second number? ");
                temp = Console.ReadLine();
            }
            second = int.Parse(temp);

            Console.WriteLine($"{first} + {second} = {first + second}\n{first} - {second} = {first - second}\n{first} * {second} = {first * second}\n{first} / {second} = {first / second}");
        }
    }
}
