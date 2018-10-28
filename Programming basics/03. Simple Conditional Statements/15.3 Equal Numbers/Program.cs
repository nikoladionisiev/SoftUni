using System;

namespace _15._3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            if (num1 == num2 && num2 == num3 && num3 == num1)
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
