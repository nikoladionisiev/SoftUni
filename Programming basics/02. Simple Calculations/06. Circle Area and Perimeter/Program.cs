using System;

namespace _06._Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("r =");
            var r = double.Parse(Console.ReadLine());

            var area = (Math.PI * r * r);

            Console.Write("Area= ");
            Console.WriteLine(area);

            var perimeter = Math.PI * (r + r);

            Console.Write("Perimeter= ");
            Console.WriteLine(perimeter);
        }
    }
}
