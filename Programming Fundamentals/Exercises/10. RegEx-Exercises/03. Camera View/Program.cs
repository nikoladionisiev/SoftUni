using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] numbers = Console.ReadLine().Split();
            string input = Console.ReadLine();
            string n1 = "{" + numbers[0] + "}";
            string n2 = "{1," + numbers[1] + "}";
           
            string pattern = $@"\|\<(\w{n1})(?<evala2>\w{n2})";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            List<string> result = new List<string>();

            foreach (Match match in matches)
            {
                result.Add(match.Groups["evala2"].Value);
                Console.WriteLine(match.Groups["evala2"].Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}


