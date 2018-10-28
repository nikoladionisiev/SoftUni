using System;

namespace _12._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine().ToLower();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
           

            double weekend = (48 - h) * 3.0 / 4;
            double numP = p * (2.0 / 3);
            double sum = weekend + numP + h;


            if (year == "normal")
            {
                Console.WriteLine(Math.Truncate(sum));
            }
            else if (year == "leap")
            {
                var result = sum + sum * 0.15;
                Console.WriteLine(Math.Truncate(result));
            }
        }
    }
}
