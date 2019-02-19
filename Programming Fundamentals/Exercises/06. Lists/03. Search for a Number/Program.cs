using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] three = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> elements = NewListOfElements(input, three);

            for (int i = 0; i < three[1]; i++)
            {
                elements.RemoveAt(0);

            }

            for (int i = 0; i < elements.Count; i++)
            {
                if (three[2] == elements[i])
                {
                    Console.WriteLine("YES!");
                    return;
                }

            }

            Console.WriteLine("NO!");

        }

        public static List<int> NewListOfElements(List<int> input, int[] three)
        {
            List<int> elements = new List<int>(three[0]);

            for (int i = 0; i < three[0]; i++)
            {

                elements.Add(input[i]);
            }
            return elements;
        }
    }
}
