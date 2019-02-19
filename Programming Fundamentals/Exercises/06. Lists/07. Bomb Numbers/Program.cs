using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split().Select(int.Parse).ToList();

            int range = bomb[1] * 2 + 1;

            for (int i = 0; i < input.Count; i++)
            {
                int index = input.IndexOf(bomb[0]);

                if (index != -1)
                {
                    int start = index - bomb[1];
                    int end = index + bomb[1];


                    if (start < 0)
                    {
                        start = 0;
                    }

                    if (end >= input.Count)
                    {
                        end = input.Count - 1;
                    }

                    input.RemoveRange(start, (end - start) + 1);
                    i = start;
                }
            }

            int total = input.Sum(item => item);
            Console.WriteLine(total);
        }
    }
}
