using System;

namespace _1._Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                NewMethod(n, i);

            }
            for (int i = n - 1; i >= 1; i--)
            {
                NewMethod(n, i);

            }
        }

        private static void NewMethod(int n, int i)
        {
            for (int j = 0; j < n - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j < i; j++)
            {
                Console.Write("* ");
            }

            Console.WriteLine("*");
        }
    }
}
