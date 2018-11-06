using System;

namespace _02._Max_Method
{
    class Biggest_number
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = GetMax(firstNumber, secondNumber);
            result = GetMax(result, thirdNumber);

            Console.WriteLine(result);
        }

        public static int GetMax(int firstNumber, int secondNumber)
        {
            int biggerNumber = 0;

            if (firstNumber >= secondNumber)
            {
                biggerNumber = firstNumber;
            }

            else 
            {
                biggerNumber = secondNumber;
            }

            return biggerNumber;

        }
    }
}
