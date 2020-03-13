using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            Action<string[]> print = r => Console.WriteLine("Sir " + string.Join("\nSir ", r));
            print(input);
        }
    }
}
