using System;
using System.Text.RegularExpressions;

namespace _02._Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();

            string pattern = $@"[^.!?]*\b{word}\b[^.!?]*";

            MatchCollection words = Regex.Matches(input, pattern);

            foreach (Match item in words)
            {
                Console.WriteLine(item);
            }

        }
    }
}
