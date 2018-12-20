using System;
using System.Linq;

namespace _04._Triple_Sum
{
    class Program
    {
        public static void Main()
        {
            //string[] arr = Console.ReadLine().Split(' ');

            //var numbers = new int[arr.Length];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    numbers[i] = int.Parse(arr[i]);
            //}

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool sumCheck = false;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int sum = numbers[i] + numbers[j];

                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                        sumCheck = true;

                    }

                }
            }
            if (!sumCheck)
            {
                Console.WriteLine("No");
                
            }

        }
    }
}
