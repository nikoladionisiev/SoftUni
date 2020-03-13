using System;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string oddEven = Console.ReadLine();

            Predicate<int> isEven = isEvenNum;

            int firstNumber = numbers[0];
            int secondNumber = numbers[1];


            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (oddEven == "odd")
                {
                    if (!isEven(i)) Console.Write(i + " ");
                }
                else
                {
                    if (isEven(i)) Console.Write(i + " ");
                }
            }

        }

        static bool isEvenNum(int n)
        {
            return n % 2 == 0;
        }
    }
}
