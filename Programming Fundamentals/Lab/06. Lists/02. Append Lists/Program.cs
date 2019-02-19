using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split('|').Reverse().ToArray();

            foreach (var item in input)
            {
                string[] nums = item.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                
                Console.Write(String.Join(" ", nums) + " ");
            }

        }
    }
}
