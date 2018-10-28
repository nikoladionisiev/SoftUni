using System;

namespace _08._Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var area = x * h / 2.0;

            Console.WriteLine("Area = " + area);
        }
    }
}
