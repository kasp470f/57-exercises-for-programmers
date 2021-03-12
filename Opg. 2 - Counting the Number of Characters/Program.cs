using System;

namespace Counting_the_Number_of_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the input string? ");
            string word = Console.ReadLine();
            Console.WriteLine($"{word} has {word.Length} characters.");
        }
    }
}
