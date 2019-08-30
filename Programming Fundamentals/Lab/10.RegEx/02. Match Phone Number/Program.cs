using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\+359[ -]2[ -]\d{3}[ -]\d{4}\b";

            MatchCollection phoneMathces = Regex.Matches(input, pattern);

            var matchedPhones = phoneMathces.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));

            Console.WriteLine("next");
            foreach (Match item in phoneMathces)
            {
                Console.Write(item +", ");
            }
        }
    }
}
