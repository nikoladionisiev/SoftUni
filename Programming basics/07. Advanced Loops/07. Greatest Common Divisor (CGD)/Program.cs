using System;

namespace _07._Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());


            while (numberB != 0)
            {
                int temp = numberA % numberB;
                numberA = numberB;
                numberB = temp;

            }
            Console.WriteLine(numberA);
        }
    }
}
