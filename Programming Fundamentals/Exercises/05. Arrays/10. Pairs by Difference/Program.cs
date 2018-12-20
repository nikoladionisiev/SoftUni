using System;
using System.Linq;
namespace _10._Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long difference = long.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] - numbers[j] == difference)
                    {
                        count++;
                    }
                }

            }

            Console.WriteLine(count);
        }
    }
}
