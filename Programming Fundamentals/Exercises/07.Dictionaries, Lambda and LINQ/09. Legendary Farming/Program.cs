using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, long> special = new SortedDictionary<string, long>();
            special.Add("shards", 0);
            special.Add("fragments", 0);
            special.Add("motes", 0);
            SortedDictionary<string, long> junk = new SortedDictionary<string, long>();


            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split();

                if (input[0] == "no")
                {
                    break;
                }
                for (int i = 0; i < input.Length; i += 2)
                {
                    if (input[i + 1] == "shards")
                    {
                        special["shards"] += int.Parse(input[i]);
                        if (special["shards"] >= 250)
                        {
                            string item = "Shadowmourne";
                            special["shards"] -= 250;
                            PrintMethod(item, junk, special);
                            return;
                        }
                    }
                    else if (input[i + 1] == "fragments")
                    {
                        special["fragments"] += int.Parse(input[i]);
                        if (special["fragments"] >= 250)
                        {
                            string item = "Valanyr";
                            special["fragments"] -= 250;
                            PrintMethod(item, junk, special);
                            return;
                        }
                    }
                    else if (input[i + 1] == "motes")
                    {
                        special["motes"] += int.Parse(input[i]);
                        if (special["motes"] >= 250)
                        {
                            string item = "Dragonwrath";
                            special["motes"] -= 250;
                            PrintMethod(item, junk, special);
                            return;

                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(input[i + 1]))
                        {
                            junk.Add(input[i + 1], int.Parse(input[i]));
                        }
                        else
                        {
                            junk[input[i + 1]] += int.Parse(input[i]);
                        }

                    }
                }

            }
        }


        static void PrintMethod(string item, SortedDictionary<string, long> junk, SortedDictionary<string, long> special)
        {
            Console.WriteLine($"{item} obtained!");

            foreach (var element in special.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{element.Key}: {element.Value}");
            }

            foreach (var element2 in junk)
            {
                Console.WriteLine($"{element2.Key}: {element2.Value}");
            }
        }
    }
}
