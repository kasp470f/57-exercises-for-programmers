using System;

namespace Opg._6___Retirement_Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            int CurrentAge = checkAge(0);
            int RetireAge = checkAge(1);

            int YearsLeft = GetYearsLeft(CurrentAge, RetireAge);
            string CurrentYear = DateTime.Now.Year.ToString();

            Console.WriteLine("You have {0} years left until you can retire.", YearsLeft);
            Console.WriteLine("It's {0}, so you can retire in {1}.", CurrentYear, GetRetireYear(YearsLeft, CurrentYear));
            Console.ReadLine();
        }

        static int GetYearsLeft(int current, int retire)
        {
            return retire - current;
        }

        static int GetRetireYear(int currentYear, string yearsLeft)
        {
            return int.Parse(yearsLeft) + currentYear;
        }

        static int checkAge(int question)
        {
            string tempString;
            do
            {
                if (question == 0)
                {
                    Console.Write("What is your current age? ");
                }
                else if (question == 1)
                {
                    Console.Write("At what age would you like to retire? ");
                }
                tempString = Console.ReadLine();
            } while (!Int32.TryParse(tempString, out _));
            return int.Parse(tempString);
        }
    }
}
