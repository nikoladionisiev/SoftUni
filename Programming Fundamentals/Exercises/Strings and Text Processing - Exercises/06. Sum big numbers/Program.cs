using System;
using System.Text;

namespace _06._Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstN = Console.ReadLine().TrimStart('0');
            string secondN = Console.ReadLine().TrimStart('0');

            int length = Math.Max(firstN.Length, secondN.Length);
            int remainder = 0;

            firstN = firstN.PadLeft(length, '0');
            secondN = secondN.PadLeft(length, '0');

            StringBuilder result = new StringBuilder(length + 1);

            for (int i = length - 1; i >= 0; i--)
            {
                int num1 = int.Parse(firstN[i].ToString());
                int num2 = int.Parse(secondN[i].ToString());

                int sum = num1 + num2 + remainder;
                int lastDigit = sum % 10;

                result.Append(lastDigit);
                remainder = sum / 10;
                
            }

            if (remainder > 0)
            {
                result.Append(remainder);
            }

            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
    }
}
