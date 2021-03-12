using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Opg43___Product_Search
{
    class Program
    {

        static void Main()
        {
            bool isAlreadyAProduct = false;
            // Read the json file
            dynamic productsJson = Newtonsoft.Json.JsonConvert.DeserializeObject(File.ReadAllText("../../Products.json"));
            Console.WriteLine("What is the product name?");
            string searchQuery = Console.ReadLine();

            for (int i = 0; i < productsJson.products.Count; i++)
            {
                isAlreadyAProduct = String.Equals(Convert.ToString(productsJson.products[i].name), searchQuery, StringComparison.CurrentCultureIgnoreCase);
                if (isAlreadyAProduct)
                {
                    Console.WriteLine("Name: {0}", productsJson.products[i].name);
                    Console.WriteLine("Price: {0:C}", productsJson.products[i].price);
                    Console.WriteLine("Quantity on hand: {0}", productsJson.products[i].quantity);
                    Main();
                }
            }

            if (!isAlreadyAProduct)
            {
                Console.WriteLine("Sorry, that product was not found in our inventory.");
                Console.WriteLine("Do you want to add that product? Yes/No");
                string answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case "yes":
                        AddProduct(searchQuery);
                        break;
                    default:
                        Main();
                        break;
                }
            }
        }

        static void AddProduct(string name)
        {
            dynamic productsJson = Newtonsoft.Json.JsonConvert.DeserializeObject(File.ReadAllText("../../Products.json"));
            Console.WriteLine("What is the price of the item?");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What quantity of the item do we have?");
            int quantity = Convert.ToInt32(Console.ReadLine());

            productsJson.products.Add(new JObject(
                    new JProperty("name", name),
                    new JProperty("price", price),
                    new JProperty("quantity", quantity)
                    ));
            File.WriteAllText(@"../../Products.json", JsonConvert.SerializeObject(productsJson, Formatting.Indented));
            Main();
        }
    }
}
