using System;
using System.Text.RegularExpressions;

namespace _06._Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";

            while (input != "end")
            {

                string replacement = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(input, pattern, replacement);
                Console.WriteLine(replaced);

                input = Console.ReadLine();
            }

        }
    }
}
