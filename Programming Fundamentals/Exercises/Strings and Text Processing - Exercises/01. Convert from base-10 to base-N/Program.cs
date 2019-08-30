using System;
using System.Linq;
using System.Numerics;

namespace _01._Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int n = int.Parse(input[0]);
            BigInteger number = new BigInteger();
            number = BigInteger.Parse(input[1]);
            BigInteger reminder = 0;
            string result = string.Empty;

            while (number > 0)
            {
                reminder = number % n;
                number /= n;
                result = reminder.ToString() + result;
            }

            Console.WriteLine(result);
        }
    }
}
