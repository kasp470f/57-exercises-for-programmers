using System;
using System.Collections.Generic;

namespace Opg._10___Self_Checkout
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> cart = new List<Item>();
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Enter the price of item {0}: ", i);
                int price = GetInt();
                Console.Write("Enter the quantity of item {0}: ", i);
                int amount = GetInt();
                cart.Add(new Item(price, amount));
            }

            int subtotal = 0;
            foreach (Item obj in cart)
            {
                subtotal += obj.GetTotalPrice();
            }

            Console.WriteLine("Subtotal: ${0:n}", subtotal);

            Console.WriteLine("Tax: ${0}", GetTax(subtotal));

            Console.WriteLine("Total: ${0}", subtotal + GetTax(subtotal));
            Console.ReadLine();
        }


        static int GetInt()
        {
            string tempString;
            do
            {
                tempString = Console.ReadLine();
            } while (!int.TryParse(tempString, out _));
            return int.Parse(tempString);
        }

        static double GetTax(int subtotal)
        {
            double tax = 0;
            tax = 0.055 * subtotal;
            return tax;
        }

    }

    public class Item
    {
        private int price;
        private int amount;

        public int Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }

        public Item(int price, int amount)
        {
            Price = price;
            Amount = amount;
        }

        internal int GetTotalPrice()
        {
            int tempPrice = 0;
            for (int i = 0; i < Amount; i++)
            {
                tempPrice += Price;
            }
            return tempPrice;
        }
    }
}
