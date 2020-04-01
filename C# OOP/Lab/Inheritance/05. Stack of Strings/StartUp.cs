using System;

namespace _05._Stack_of_Strings
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the sum:");
            double firstInput = double.Parse(Console.ReadLine());
            Console.Write("Enter percentage:");
            double percentage = double.Parse(Console.ReadLine());

            firstInput -= (firstInput * percentage / 100);
            Console.WriteLine("The result is:" + firstInput);
        }
    }
}
