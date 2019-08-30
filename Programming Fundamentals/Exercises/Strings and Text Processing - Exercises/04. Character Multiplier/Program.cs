using System;
using System.Linq;

namespace _04._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string first = input[0];
            string second = input[1];

            int length = Math.Max(first.Length, second.Length);

            first = first.PadRight(length, '\x001');
            second = second.PadRight(length, '\x001');

            double result = 0.0;

            for (int i = 0; i < length; i++)
            {
                result += first[i] * second[i];
            }
            Console.WriteLine(result);
        }
    }
}
