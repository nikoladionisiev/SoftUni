using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {

            int amount = int.Parse(Console.ReadLine());

            var priceOf = new Products();
            priceOf.products = new Dictionary<string, decimal>();

            var dict = new SortedDictionary<string, Customer>();

            for (int i = 0; i < amount; i++)
            {
                string[] inputProduct = Console.ReadLine().Split('-');
                priceOf.products[inputProduct[0]] = decimal.Parse(inputProduct[1]);
            }

            while (true)
            {
                string[] inputCustomer = Console.ReadLine().Split(new char[] { ',', '-' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputCustomer[0] == "end of clients")
                {
                    break;
                }
                
                string customer = inputCustomer[0]; // Тоshko
                string currentProduct = inputCustomer[1]; // Beer
                int quantityOfProducts = int.Parse(inputCustomer[2]); // 3



                if (priceOf.products.ContainsKey(currentProduct)) // проверяваме дали продукта е наличен
                {
                    // всиччко правим ако е наличен само

                    if (dict.ContainsKey(customer)) // проверяваме дали клиента е добавен в речника, дали го има в него
                    {
                        if (dict[customer].purchases.ContainsKey(currentProduct)) // проверяваме дали продукта вече е в речника за покупките на клиента
                        {
                            dict[customer].purchases[currentProduct] += quantityOfProducts; // ако имаме наличен вече продукт в речника за покупки, увеличаваме количеството
                        }
                        else // ако продукта не е наличен в речника за покупки на клиента
                        {
                            // просто му даваме начална стойност - количеството
                            dict[customer].purchases[currentProduct] = quantityOfProducts;
                        }
                        // тук събираме цената на всички купени продукти
                        dict[customer].bill += quantityOfProducts * priceOf.products[currentProduct];
                    }
                    else // клиента не е добавен в речника, имаме нов клиент
                    {
                        dict[customer] = new Customer(); // нов обект за потребителя
                        dict[customer].purchases = new SortedDictionary<string, int>(); // нов речник за покупките
                        dict[customer].purchases[currentProduct] = quantityOfProducts; // задаваме първата покупка и количеството
                        dict[customer].bill = quantityOfProducts * priceOf.products[currentProduct]; // цена на първата покупка
                    }
                }

             


            }


            decimal total = new decimal();

            foreach (var customer in dict)
            { 
                Console.WriteLine(customer.Key);

                foreach (var item in customer.Value.purchases)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {customer.Value.bill:F2}");
                total += customer.Value.bill;
            }
            Console.WriteLine($"Total bill: {total:F2}");
        }

        public static void print(Dictionary<string, Dictionary<string, int>> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine("---  Key = {0}, Value = {1}", item.Key, item.Value);
                }
            }
            
        }


    }



}
