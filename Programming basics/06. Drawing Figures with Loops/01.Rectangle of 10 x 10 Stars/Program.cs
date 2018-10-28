using System;

namespace _01.Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= 10; row++)
            {
                for (int col = 1; col <= 10; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
