using System;
using System.Linq;

namespace _02._Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] rotated = new int[numbers.Length];

            for (int i = 0; i < k; i++)
            {
                int lastDigit = numbers[numbers.Length - 1];

                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];         
                    rotated[j] += numbers[j];
                }

                numbers[0] = lastDigit;
                rotated[0] += numbers[0];

            }

            for (int i = 0; i < rotated.Length; i++)
            {
                Console.Write(rotated[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
