using System;

namespace _03._Square_Of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
