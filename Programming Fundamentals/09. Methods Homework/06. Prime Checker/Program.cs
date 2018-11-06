using System;

namespace _06._Prime_Checker
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            bool primeOrNot = IsPrime(number);

            Console.WriteLine(primeOrNot);
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
