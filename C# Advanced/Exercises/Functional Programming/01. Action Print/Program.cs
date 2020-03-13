using System;
using System.Linq;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            Action<string[]> print = input => Console.WriteLine(string.Join("\n", input));
            print(input);
        }
    }
}
