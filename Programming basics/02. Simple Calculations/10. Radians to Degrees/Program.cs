using System;

namespace _10._Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("r=");
            var r = double.Parse(Console.ReadLine());

            var degree = Math.Round(r * 180 / Math.PI);

            Console.WriteLine("Degree= " + degree);
        }
    }
}
