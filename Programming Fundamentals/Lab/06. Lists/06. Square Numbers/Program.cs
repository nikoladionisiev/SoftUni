using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (Math.Sqrt(input[i]) % 1 != 0)
                {
                    input.Remove(input[i]);
                    i--;
                }
            }

            input.Sort();
            input.Reverse();
            
            Console.WriteLine(string.Join(" ", input));

        }
    }
}
