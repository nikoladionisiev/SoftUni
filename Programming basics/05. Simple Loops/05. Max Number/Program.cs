using System;

namespace _05._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;

            for (int index = 0; index < n; index += 1)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
