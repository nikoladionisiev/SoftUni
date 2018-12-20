using System;
using System.Linq;

namespace _06._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int digit = 0;
            int max = 0;
            

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentIndex = numbers[i];
                int longest = 0;

                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        longest++;
                        if (max < longest)
                        {
                            max = longest;
                            digit = currentIndex;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < max; i++)
            {
                Console.Write(digit + " " );
            }
            Console.WriteLine();
        }
    }
}
