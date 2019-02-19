using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            //8 2 2 8 2 2 3 7
            // 2 2 2 2 3 7 8 8 
            int count = 1;
            input.Sort();

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i - 1])
                {
                    count++;
                }

                else
                {
                    Console.WriteLine($"{input[i - 1]} -> {count}");
                    count = 1;

                }

            }
            Console.WriteLine($"{input[input.Count - 1]} -> {count}");


        }
    }
}
