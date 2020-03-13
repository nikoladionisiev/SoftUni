using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            //string input = Console.ReadLine();
            //Stack<char> numbers = new Stack<char>(input.Length);

            //for (int i = 0; i < input.Length; i++)
            //{
            //    numbers.Push(input[i]);
            //}

            //for (int i = 0; i < input.Length; i++)
            //{
            //    Console.Write(numbers.Pop());
            //}

            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var stack = new Stack<long>();

            for (int i = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }

            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
