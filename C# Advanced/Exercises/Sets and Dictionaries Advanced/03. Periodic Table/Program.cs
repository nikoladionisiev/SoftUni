using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> chemicals = new SortedSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                foreach (var chemicalName in input)
                {
                    chemicals.Add(chemicalName);
                }
            }

            Console.WriteLine(string.Join(' ', chemicals));
        }
    }
}
