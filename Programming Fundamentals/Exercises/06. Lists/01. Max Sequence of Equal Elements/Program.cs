using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> input = Console.ReadLine().Split().Select(long.Parse).ToList();

            int count = 1;
            int start = 0;
            int bestStart = 0;
            int bestLenght = 1;

            //2 2 2 3 3
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i - 1])
                {
                    count++;
                    
                }

                else
                {
                    start = i;
                    count = 1;
                }
                
                if (count > bestLenght)
                {
                    bestStart = start;
                    bestLenght = count;
                    
                }
            }

            for (int i = bestStart; i < bestStart + bestLenght; i++)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
