using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] values = input.Split(' ');
            Stack<string> stack = new Stack<string>(values.Reverse());

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string operant = stack.Pop();
                int second = int.Parse(stack.Pop());

                switch (operant)
                {
                    case "+":
                        stack.Push((first + second).ToString());
                        break;
                    case "-":
                        stack.Push((first - second).ToString());
                        break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
