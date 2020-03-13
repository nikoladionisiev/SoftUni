using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lenght = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            int n = lenght[0];
            int m = lenght[1];

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                firstSet.Add(currentNumber);
            }

            for (int i = 0; i < m; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                secondSet.Add(currentNumber);
            }

            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
