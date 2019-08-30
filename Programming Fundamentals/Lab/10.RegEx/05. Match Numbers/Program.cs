using System;
using System.Text.RegularExpressions;

namespace _05._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var regex = Regex.Matches(input, pattern);

            foreach (Match number in regex)
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
