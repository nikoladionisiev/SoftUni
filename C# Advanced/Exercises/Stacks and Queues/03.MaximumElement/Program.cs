using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumElement
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int command = input[0];

                if (command == 1)
                {
                    int currentNumber = input[1];
                    stack.Push(currentNumber);
                }
                else if (command == 2)
                {
                    stack.Pop();
                }
                else if (command == 3)
                {
                    Console.WriteLine(stack.Max());
                }
               
            }
        }
    }
}
