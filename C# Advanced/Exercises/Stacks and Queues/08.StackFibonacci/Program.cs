using System;
using System.Collections.Generic;

namespace _08.StackFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Stack<long> fibonacci = new Stack<long>();

            fibonacci.Push(0);
            fibonacci.Push(1);

            for (int i = 0; i < number - 1; i++)
            {
                //0 1 1 2 3 5
                long latestNumber = fibonacci.Pop();
                long nextNumber = fibonacci.Peek() + latestNumber;

                fibonacci.Push(latestNumber);
                fibonacci.Push(nextNumber);
            }
            Console.WriteLine(fibonacci.Peek());
        }
    }
}
