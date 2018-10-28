using System;

namespace _07._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fruit: ");
            string fruit = Console.ReadLine().ToLower();
            Console.Write("Day: ");
            string day = Console.ReadLine().ToLower();
            Console.Write("Quantity: ");
            double quantity = double.Parse(Console.ReadLine());

            // Monday
            if (day == "monday" || day == "tuesday" || day == "wednesday"
                || day == "thursday" || day == "friday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine(quantity * 2.50);
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine(quantity * 1.20);
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine(quantity * 0.85);
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine(quantity * 1.45);
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine(quantity * 2.70);
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine(quantity * 5.50);
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine(quantity * 3.85);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine(quantity * 2.70);
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine(quantity * 1.25);
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine(quantity * 0.90);
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine(quantity * 1.60);
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine(quantity * 3.00);
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine(quantity * 5.60);
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine(quantity * 4.20);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }


        }
    }
}
