using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main()
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var dict = new Dictionary<double, int>();

            foreach (var item in arr)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }

            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }

        }
    }
}
