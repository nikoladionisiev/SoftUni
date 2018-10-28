using System;

namespace _04._Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // number 3

            for (int i = 0; i <= n; i++) //0 <= 3, 1<=3,
            {
                double num = Math.Pow(2, i);// 2^0=1, 2^1=4
                if (i % 2 == 0)
                {
                    Console.WriteLine(num);
                }

            }
        }
    }
}
