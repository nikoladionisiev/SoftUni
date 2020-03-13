using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item + (item * 0.2):f2}");
            }
        }
    }
}
