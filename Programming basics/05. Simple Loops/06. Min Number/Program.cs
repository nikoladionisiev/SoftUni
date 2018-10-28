using System;

namespace _06._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;

            for (int index = 0; index < n; index += 1)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }

            if (minNumber != int.MaxValue)
            {
                Console.WriteLine(minNumber);
            }
        }
    }
}
