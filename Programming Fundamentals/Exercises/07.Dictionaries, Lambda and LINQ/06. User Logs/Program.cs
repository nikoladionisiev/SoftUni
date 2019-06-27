using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
          
            SortedDictionary<string, Dictionary<string, int>> dictionary = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(new Char[] { '=', ' ' }).ToArray();


                if (input[0] == "end")
                {
                    break;
                }

                string IP = input[1];
                string user = input[5];



                if (dictionary.ContainsKey(user))
                {

                    if (dictionary[user].ContainsKey(IP))
                    {
                        dictionary[user][IP]++;
                    }
                    else
                    {
                        dictionary[user][IP] = 1;
                    }

                }
                else
                {
                    dictionary[user] = new Dictionary<string, int>();
                    dictionary[user][IP] = 1;
                }

            }

            foreach (var item in dictionary)
            {

                Console.WriteLine($"{item.Key}:");

                foreach (var item2 in item.Value)
                {
                    Console.Write($"{item2.Key} => {item2.Value}");
                    if (item2.Key != item.Value.Keys.Last()) Console.Write(", ");
                }
                Console.WriteLine('.');
            }
        }
    }
}

