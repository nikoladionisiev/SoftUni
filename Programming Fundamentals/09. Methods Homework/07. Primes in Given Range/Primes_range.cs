using System;
using System.Collections.Generic;

namespace _07._Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            var primeInRange = FindPrimesInRange(startNum, endNum);

            Console.WriteLine(string.Join(", " ,primeInRange));
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();

            for (int currentNum = startNum; currentNum <= endNum ; currentNum++)
            {

                if (IsPrime(currentNum))
                {
                    primes.Add(currentNum);
                }
            }

            return primes;
        }

        public static bool IsPrime(long number)
        {
            bool prime = true;

            if (number == 0 || number == 1)
            {
                prime = false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            return prime;

        }

    }
}
