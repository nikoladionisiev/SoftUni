using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new SortedDictionary<string, SortedDictionary<string, long>>();

            long n = int.Parse(Console.ReadLine());



            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string ip = input[0];
                string name = input[1];
                long logs = int.Parse(input[2]);


                if (dictionary.ContainsKey(name))
                {
                    if (dictionary[name].ContainsKey(ip))
                    {

                        dictionary[name][ip] += logs;
                    }
                    else
                    {
                        dictionary[name][ip] = logs;
                    }
                }
                else
                {
                    dictionary.Add(name, new SortedDictionary<string, long>());
                    dictionary[name].Add(ip, logs);
                }

            }

            foreach (var item in dictionary)
            {
                Console.Write(item.Key + ": ");
                long sumLogs = 0;

                List<string> list = new List<string>();

                foreach (var item2 in item.Value)
                {
                    sumLogs += item2.Value;
                    list.Add(item2.Key);
                }

                Console.Write(sumLogs + " [");
                Console.Write(string.Join(", ", list));
                Console.WriteLine("]");
            }
        }
    }
}
