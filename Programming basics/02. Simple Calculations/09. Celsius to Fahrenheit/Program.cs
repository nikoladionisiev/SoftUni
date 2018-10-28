using System;

namespace _09._Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("C=");
            var C = double.Parse(Console.ReadLine());

            var f = C * 1.8 + 32; ;

            Console.WriteLine("F= " + f);
        }
    }
}
