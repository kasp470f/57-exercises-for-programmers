using System;

namespace Opg._7___Area_of_a_Rectangular_Room
{
    class Program
    {
        const double convfact = 0.09290304;
        static void Main(string[] args)
        {
            Console.Write("What is the length of the room in feet? ");
            double length = checkDouble(Console.ReadLine());
            Console.Write("What is the width of the room in feet? ");
            double width = checkDouble(Console.ReadLine());

            Console.WriteLine($"You entered dimensions of {length} feet by {width} feet.");
            Console.WriteLine("The area is");
            double sqfeet = length * width;
            Console.WriteLine($"{sqfeet} square feet");
            Console.WriteLine($"{AreaOfRectRoom(sqfeet)} square meters");
        }

        static double checkDouble(string str)
        {
            string temp = str;
            double number;
            while (!double.TryParse(temp, out number))
            {
                temp = Console.ReadLine();
            }
            return number;
        }

        static double AreaOfRectRoom(double sqfeet)
        {
            return sqfeet * convfact;
        }
    }
}
