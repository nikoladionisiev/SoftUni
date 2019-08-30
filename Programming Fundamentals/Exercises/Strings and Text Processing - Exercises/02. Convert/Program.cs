using System;
using System.Linq;
using System.Numerics;

namespace _02._Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ns = Console.ReadLine().Split();
            BigInteger n = BigInteger.Parse(ns[0]);
            BigInteger number = BigInteger.Parse(ns[1]);
           

            BigInteger result = new BigInteger();

            int counter = 0;
            while (number > 0)
            {
                BigInteger reminder = number % 10;
                result += reminder * BigInteger.Pow(n, counter);

                counter++;
                number /= 10;
            }

            Console.WriteLine(result);
        }
    }
}
