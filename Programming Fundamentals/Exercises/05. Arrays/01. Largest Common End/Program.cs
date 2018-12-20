using System;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();

            int shorterInput = Math.Min(firstInput.Length, secondInput.Length);

            int counter = 0;
            int secondCounter = 0;

            for (int i = 0; i < shorterInput; i++)
            {
                if (firstInput[i] == secondInput[i])
                {
                    counter++;
                }

                if (firstInput[firstInput.Length - 1 - i] == secondInput[secondInput.Length - 1 - i])
                {
                    secondCounter++;
                }
            }


            Console.WriteLine(Math.Max(counter, secondCounter));
        }
    }
}
