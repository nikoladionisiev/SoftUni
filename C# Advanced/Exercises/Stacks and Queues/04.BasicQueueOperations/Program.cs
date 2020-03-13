using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < parameters[0]; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < parameters[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(parameters[2]))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count <= 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }

        }
    }
}
