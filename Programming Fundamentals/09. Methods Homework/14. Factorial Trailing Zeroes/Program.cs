using System;
using System.Numerics;

namespace _14._Factorial_Trailing_Zeroes
{
    class Program
    {

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = Factorial(number);
            BigInteger zeroes = Zeroes(factorial);

            Console.WriteLine(zeroes);
        }

        public static BigInteger Factorial(int number)
        {

            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static BigInteger Zeroes(BigInteger number)
        {

            string numberToString = number.ToString();
            int count = 0;

            for (int i = numberToString.Length - 1; i >= 0; i--)
            {

                if (numberToString[i] == '0')
                {
                    count ++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}