using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> arr = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");

                string color = input[0];
                string[] clothes = input[1].Split(",");

                if (!arr.ContainsKey(color))
                {
                    arr.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string currentItem = clothes[j];

                    if (!arr[color].ContainsKey(currentItem))
                    {
                        arr[color].Add(currentItem, 0);
                    }
                    arr[color][currentItem] += 1;
                }
            }

            string[] targetItem = Console.ReadLine().Split();

            string targetColor = targetItem[0];
            string itemName = targetItem[1];

            foreach (var color in arr)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var x in color.Value)
                {
                    Console.Write($"* {x.Key} - {x.Value}");

                    if (color.Key == targetColor && x.Key == itemName)
                    {
                        Console.Write(" (found!)");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
