using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> items = Console.ReadLine().Split().Select(int.Parse).ToList();

            items.Reverse();

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] < 0)
                {
                    items.RemoveAt(i);
                    i--;
                }

            }

            if (items.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", items));
            }
        
        }
    }
}
