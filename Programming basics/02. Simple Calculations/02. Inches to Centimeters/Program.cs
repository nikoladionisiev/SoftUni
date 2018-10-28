using System;

namespace _02._Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());

            double cm = 2.54 * inches;

            Console.WriteLine(cm);
        }
    }
}
