using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.BasicStackOperations
{
    class Program
    {
        static void Main()
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int pushingElements = n[0];
            int popingElements = n[1];
            int checkNumber = n[2];

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < pushingElements; i++)
            {
                stack.Push(numbers[i]);   
            }

            for (int i = 0; i < popingElements; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(checkNumber))
            {
                Console.WriteLine("true");
            }
            else if(stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
