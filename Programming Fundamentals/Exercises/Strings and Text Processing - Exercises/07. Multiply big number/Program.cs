using System;
using System.Text;

namespace _07._Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                Environment.Exit(0);
            }

            int remainder = 0;
            int sum = 0;

            StringBuilder result = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int num = int.Parse(input[i].ToString());

                sum = num * multiplier + remainder; 
                remainder = sum / 10;
                result.Append(sum % 10); 

            }

            result.Append(remainder);

            string output = result.ToString().TrimEnd('0');

            if (remainder > 0)
            {
                result.Append(remainder);
            }

            for (int i = output.Length - 1; i >= 0; i--)
            {
                Console.Write(output[i]);
            }
            Console.WriteLine();
        }
    }
}
