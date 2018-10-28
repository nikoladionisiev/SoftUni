using System;

namespace _11._USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("USD= ");
            var USD = double.Parse(Console.ReadLine());

            double BGN = Math.Round(USD * 1.79549, 2);

            Console.WriteLine("BGN= " + BGN);
        }
    }
}
