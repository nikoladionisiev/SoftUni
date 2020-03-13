using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();


            foreach (var currentCharacter in input)
            {
                if (!symbols.ContainsKey(currentCharacter))
                {
                    symbols.Add(currentCharacter, 0);
                }
                symbols[currentCharacter] += 1;
            }

            foreach (var item in symbols)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
            
        }
    }
}
