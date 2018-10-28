using System;

namespace _04.Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");

            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.Write("Greater number:");
                Console.Write(num1);
            }

            else
            {
                Console.Write("Greater number:");
                Console.WriteLine(num2);
            }
        }
    }
}
