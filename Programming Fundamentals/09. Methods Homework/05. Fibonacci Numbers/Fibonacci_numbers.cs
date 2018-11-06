using System;

namespace _05._Fibonacci_Numbers
{
    class Fibonacci_numbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int first = 1;
            int second = 1;

            for (int i = 0; i < n - 1; i++)
            {
                int third = first + second;
                first = second;
                second = third;
            }

            Console.WriteLine(second);
        }

    }

}
