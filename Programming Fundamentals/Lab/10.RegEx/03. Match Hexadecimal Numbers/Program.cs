using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b(?:0x)?[0-9A-F]+\b";

            var number = Regex.Matches(input, pattern).Cast<Match>().Select(x => x.Value).ToArray();

            Console.WriteLine(string.Join(" ", number));
        }
    }
}
