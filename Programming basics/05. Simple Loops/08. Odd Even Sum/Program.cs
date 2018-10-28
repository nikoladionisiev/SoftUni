using System;

namespace _08._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var odd = 0;
            var even = 0;

            for (int i = 0; i < n; i++)
            {
                var element = int.Parse(Console.ReadLine());
                if (i % 2 == 0) even += element;
                else odd += element;
            }

            if (odd == even)
            {
                Console.WriteLine($"Yes, sum = {even}");
            }

            else
            {
                int diff = Math.Abs(even - odd);
                Console.WriteLine($"No , diff = {diff}");
            }
        }
    }
}
