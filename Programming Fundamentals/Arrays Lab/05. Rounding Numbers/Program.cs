using System;
using System.Linq;


namespace _05._Rounding_Numbers
{
    class Program
    {
        public static void Main()
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();



            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
            
        }
    }
}
