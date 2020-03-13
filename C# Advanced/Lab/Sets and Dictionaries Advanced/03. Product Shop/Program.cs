using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main()
        {
            

            SortedDictionary<string, Dictionary<string, double>> arr = new SortedDictionary<string, Dictionary<string, double>>();


            while (true)
            {
                string[] input = Console.ReadLine().Split(", ");

                if (input[0] == "Revision")
                {
                    break;
                }

                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);


                if (!arr.ContainsKey(shop))
                {
                    arr[shop] = new Dictionary<string, double>();
                    arr[shop].Add(product, price);
                }
                else
                {
                    arr[shop].Add(product, price);
                }
            }

            foreach (var shop in arr)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
