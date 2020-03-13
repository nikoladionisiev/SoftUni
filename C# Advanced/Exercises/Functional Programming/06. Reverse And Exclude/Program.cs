using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int divNumber = int.Parse(Console.ReadLine());

            Console.Write(string.Join(" ", numbers.Reverse().Where(x =>x % divNumber != 0)));
        }
    }
}
