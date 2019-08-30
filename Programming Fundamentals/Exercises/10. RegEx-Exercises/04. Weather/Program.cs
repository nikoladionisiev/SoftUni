using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<city>[A-Z]{2})(?<temperature>[0-9]{2}\.[0-9]{1,2})(?<weather>[a-zA-Z]+)";

            SortedDictionary<string, List<string>> result = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string checkInput = Console.ReadLine();

                if (checkInput == "end")
                {
                    break;
                }

                string[] input = checkInput.Split('|');

                var matches = Regex.Matches(input[0], pattern);

                if (input.Length > 1)
                {
                    foreach (Match match in matches)
                    {
                        var city = match.Groups["city"].Value;
                        var temperature = match.Groups["temperature"].Value;
                        var weather = match.Groups["weather"].Value;

                        if (result.ContainsKey(city))
                        {
                            result[city][0] = temperature;
                            result[city][1] = weather;
                        }
                        else
                        {
                            result[city] = new List<string>();
                            result[city].Add(temperature);
                            result[city].Add(weather);
                        }

                    }
                }
            }

            foreach (var entry in result.OrderBy(x => x.Value[0]).ToDictionary(x => x.Key, x => x.Value))
            {
                Console.WriteLine($"{entry.Key} => {double.Parse(entry.Value[0]):F2} => {entry.Value[1]}");
            }
        }
    }
}
