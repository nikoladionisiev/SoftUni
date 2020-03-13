using System;
using System.Collections.Generic;
namespace _5.HotPotato
{
    class Program
    {
        static void Main()
        {
            var children = Console.ReadLine().Split(' ');
            int number = int.Parse(Console.ReadLine());


            Queue<string> queue = new Queue<string>(children);

            while (queue.Count != 1)
            {
                for (int i = 1; i < number; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

          
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
