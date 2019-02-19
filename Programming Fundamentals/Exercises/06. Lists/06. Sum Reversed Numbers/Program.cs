using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(s => ReverseString(s)).ToList();

            int sum = new int();

            for (int i = 0; i < input.Count; i++)
            {
                sum += input[i];
            }

            Console.WriteLine(sum);
        }
        
        static int ReverseString(string s)
        {
            int num = int.Parse(s);
            int result = 0;

            while (num > 0)
            {
                int n = num % 10;
                result = result * 10 + n;
                num /= 10;
            }

            return result;
        }
    }
}
