using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> arr = new Dictionary<string, Dictionary<string, List<string>>>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string contintent = input[0];
                string country = input[1];
                string city = input[2];

                if (!arr.ContainsKey(contintent))
                {
                    arr.Add(contintent, new Dictionary<string, List<string>>());
                }

                if (!arr[contintent].ContainsKey(country))
                {
                    arr[contintent].Add(country, new List<string>());
                }

                arr[contintent][country].Add(city);
            }

            foreach (var continent in arr)
            {
                Console.WriteLine(continent.Key + ":");

                foreach (var country in continent.Value)
                {
                    Console.Write(country.Key + " -> ");
                    Console.WriteLine(string.Join(", ", country.Value));
                }
            }
        }
    }
}
