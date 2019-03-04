using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            //Java C# PHP PHP JAVA C java

            List<string> input = Console.ReadLine().ToLower().Split().ToList();

            Dictionary<string, int> count = new Dictionary<string, int>();


            foreach (var key in input)
            {
                if (!count.ContainsKey(key))
                {
                    count.Add(key, 0);
                }

                count[key]++;
            }


            bool isFirst = true;
 
            foreach (KeyValuePair<string, int> kvp in count)
            {

                if (kvp.Value % 2 != 0)
                {
                    if (!isFirst)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(kvp.Key);
                    isFirst = false;
                }
            }
        }
    }
}
