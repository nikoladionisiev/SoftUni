using System;
using System.Linq;

namespace _03._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            int mid = numbers.Length / 2;

            int[] firstWing = new int[k];
            int[] secondWing = new int[k];
            int[] middle = new int[mid];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < k)
                {
                    firstWing[i] = numbers[i];
                }
                else if (i >= k && i < k + mid)
                {
                    middle[i - k] = numbers[i];
                }
                else
                {
                    secondWing[i - k - mid] = numbers[i];
                }
            }

            firstWing = firstWing.Reverse().ToArray();
            secondWing = secondWing.Reverse().ToArray();
            int[] wings = ConcatenateArrays(firstWing, secondWing);

            PrintTwoSumArray(middle, wings);
        }

        public static int[] ConcatenateArrays(int[] arr1, int[] arr2)
        {
            int[] new_arr = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < new_arr.Length; i++)
            {
                if (i < arr1.Length)
                {
                    new_arr[i] = arr1[i];
                }
                else
                {
                    new_arr[i] = arr2[i - arr1.Length];
                }
            }
            return new_arr;
        }

        public static void PrintTwoSumArray(int[] arr1, int[] arr2)
        {
            // Printing the sum of two items of even lenght arrays.
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + arr2[i] + " ");
            }
        }
    }
}
