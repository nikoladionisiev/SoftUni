using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dictionary = new Dictionary<string, Dictionary<string, long>>();



            int sumPopulation = 1; ;

            while (true)
            {
                string[] input = Console.ReadLine().Split('|').ToArray();

                if (input[0] == "report")
                {
                    break;
                }

                string city = input[0];
                string country = input[1];
                int population = int.Parse(input[2]);

                if (dictionary.ContainsKey(country))
                {
                    if (dictionary[country].ContainsKey(city))
                    {
                        dictionary[country][city] += population;
                    }
                    else
                    {
                        dictionary[country][city] = population;
                    }
                }
                else
                {


                    dictionary[country] = new Dictionary<string, long>();
                    dictionary[country][city] = population;
                }

            }

            dictionary = dictionary.OrderByDescending(x => x.Value.Sum(y => y.Value)).ToDictionary(x => x.Key, x => x.Value);


            foreach (var item in dictionary)
            {

                Console.WriteLine($"{item.Key} (total population: {item.Value.Sum(x => x.Value)})");

                foreach (var item2 in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{item2.Key}: {item2.Value}");

                }

            }
        }
    }
}
