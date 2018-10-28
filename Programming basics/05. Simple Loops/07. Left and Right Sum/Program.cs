using System;

namespace _07._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                leftSum = leftSum + number;
            }

            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                rightSum = rightSum + number;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }

            else
            {
                int diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No,diff {diff}");
            }
        }
    }
}
