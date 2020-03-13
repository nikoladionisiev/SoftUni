using System;
using System.Collections.Generic;

namespace _6.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();

            int count = 0;
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
               
                if (input == "green")
                {
                    for (int i = 0; i < number; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            count++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);

                }

            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
