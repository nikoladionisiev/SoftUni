﻿using System;
using System.Numerics;

namespace _13._Factorial
{
    class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(number));
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
    }
}
