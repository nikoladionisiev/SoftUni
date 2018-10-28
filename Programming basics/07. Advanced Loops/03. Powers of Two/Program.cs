using System;

namespace _03._Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
