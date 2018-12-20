using System;
using System.Linq;

namespace _07._Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main()
        {
            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long start = 0;
            long lenght = 1;

            long bestStart = 0;
            long bestLenght = 0;

            for (long i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    lenght++;
                    
                    
                    //3 2 3 4 2 2 4
                    //0 1 2 3 4 5 6    
                }
                else
                {
                    start = i;
                    lenght = 1;

                }

                if (lenght > bestLenght)
                {
                    bestStart = start;
                    bestLenght = lenght;
                }
            }

            for (long i = bestStart; i < bestStart + bestLenght; i++)
            {
                Console.Write(numbers[i] + " ");
            }



        }
    }
}
