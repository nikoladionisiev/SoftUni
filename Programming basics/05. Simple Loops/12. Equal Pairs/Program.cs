using System;

namespace _12._Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[2 * n];
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < 2 * n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            if (n == 1 && arr[0] == arr[1])
            {
                Console.WriteLine("Yes, value={0}", arr[0] * 2);
            }
            else
            {
                for (int i = 0; i < arr.Length - 3; i++)
                {
                    sum1 = arr[i] + arr[i + 1];
                    sum2 = arr[i + 2] + arr[i + 3];
                }
                if (sum1 == sum2)
                {
                    Console.WriteLine("Yes, value={0}", sum2);
                }
                else
                {
                    Console.WriteLine("NO, maxdiff ={0}", Math.Abs(sum2 - sum1));
                }
            }
        }
    }
}
