using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray().Reverse().ToArray();

            Console.WriteLine(input);

        }
    }
}
