using System;

namespace Opg._13___Compound_Interest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the principal amount? ");
            int P = GetUserInt();
            Console.Write("What is the rate? ");
            double r = GetUserDouble();
            Console.Write("What is the number of years? ");
            int t = GetUserInt();
            Console.Write("What is the number of times the interest is compounded per year? ");
            int n = GetUserInt();

            Console.WriteLine("${0} invested at {1}% for {2} years compounded {3} times per year is ${4:0.00}.", P, r, t, n, GetInvestment(P, r, t, n));

        }

        static double GetInvestment(int P, double r, int t, int n)
        {
            return P * Math.Pow((1 + (r / 100) / n), n * t);
        }


        static int GetUserInt()
        {
            string tempString;
            do
            {
                tempString = Console.ReadLine();
            } while (!int.TryParse(tempString, out _));
            return int.Parse(tempString);
        }

        static double GetUserDouble()
        {
            string tempString;
            do
            {
                tempString = Console.ReadLine();
            } while (!double.TryParse(tempString, out _));
            return double.Parse(tempString);
        }
    }
}
