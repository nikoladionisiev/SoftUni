using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _01._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(\s[a-z][\w-_.]*\w@\w[\w-]+\.[\w]+(\.[\w]+)?)";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }

        }
    }
}
