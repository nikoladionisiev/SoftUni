using System;

namespace _05._Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            if (num >= 100 && num <= 200 || num == 0)
            {
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
