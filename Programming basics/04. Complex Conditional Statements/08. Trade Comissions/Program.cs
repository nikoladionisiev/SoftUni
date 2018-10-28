using System;

namespace _08._Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sale = double.Parse(Console.ReadLine());


            if (sale >= 0 && sale <= 500)
            {
                if (city == "sofia")
                {
                    Console.WriteLine("{0:f2}", (5 * sale) / 100);
                }
                else if (city == "varna")
                {
                    Console.WriteLine("{0:f2}", (4.5 * sale) / 100);
                }
                else if (city == "plovdiv")
                {
                    Console.WriteLine("{0:f2}", (5.5 * sale) / 100);
                }


            }
            else if (sale > 500 && sale <= 1000)
            {
                if (city == "sofia")
                {
                    Console.WriteLine("{0:f2}", (7 * sale) / 100);
                }
                else if (city == "varna")
                {
                    Console.WriteLine("{0:f2}", (7.5 * sale) / 100);
                }
                else if (city == "plovdiv")
                {
                    Console.WriteLine("{0:f2}", (8 * sale) / 100);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sale > 1000 && sale <= 10000)
            {
                if (city == "sofia")
                {
                    Console.WriteLine("{0:f2}", (8 * sale) / 100);
                }
                else if (city == "varna")
                {
                    Console.WriteLine("{0:f2}", (10 * sale) / 100);
                }
                else if (city == "plovdiv")
                {
                    Console.WriteLine("{0:f2}", (12 * sale) / 100);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sale > 10000)
            {
                if (city == "sofia")
                {
                    Console.WriteLine("{0:f2}", (12 * sale) / 100);
                }
                else if (city == "varna")
                {
                    Console.WriteLine("{0:f2}", (13 * sale) / 100);
                }
                else if (city == "plovdiv")
                {
                    Console.WriteLine("{0:f2}", (14.5 * sale) / 100);
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
