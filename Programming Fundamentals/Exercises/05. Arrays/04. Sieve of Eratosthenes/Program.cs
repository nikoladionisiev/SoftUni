using System;
using System.Linq;

namespace _04._Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number++;

            bool[] primes = new bool[number];

            for (int i = 0; i < number; i++)
            {
                primes[i] = true;
            }

            primes[0] = primes[1] = false;

            for (int i = 1; i < Math.Sqrt(number); i++)
            {
                if (primes[i])
                {
                    for (int j = (int)Math.Pow(i, 2); j <number; j+=i)
                    {
                        primes[j] = false;
                    }
                }
            }

            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
