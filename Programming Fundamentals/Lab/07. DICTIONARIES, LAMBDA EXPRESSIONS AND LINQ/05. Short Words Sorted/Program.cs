using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().ToLower().Split(" .,:;()[]\"\'\\/!?".ToCharArray() ,StringSplitOptions.RemoveEmptyEntries).ToList();

            input = input.Where(w => w.Length <5).OrderBy(w => w).Distinct().ToList();
          

            Console.WriteLine(string.Join(", " ,input));

        }
    }
}
