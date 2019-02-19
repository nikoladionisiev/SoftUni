using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {

            //Learn programming at SoftUni: Java, PHP, JS, HTML 5, CSS, Web, C#, SQL, databases, AJAX, etc.

            List<string> input = Console.ReadLine().Split(",;:.!()\"'\\/[] ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowercase = new List<string>();
            List<string> mixed = new List<string>();
            List<string> uppercase = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
               
                for (int j = 0; j < input[i].Length ; j++)
                {
                    if (char.IsUpper(input[i][j]))
                    {
                        uppercase.Add(input[i]);
                        
                    }
                    //else if (j != 0 && Char.IsUpper(input[i][j]))
                    //{
                    //    mixed.Add(input[i]);
                    //}
                    //else
                    //{
                    //    lowercase.Add(input[i]);
                    //}

                }
            }

            //string word = "Vladislav";

            //for (int i = 0; i < word.Length; i++)
            //{
            //    Console.WriteLine(word[i]);
            //}

            //Console.Write("Lower-case: " + string.Join("", lowercase));
            //Console.Write("Mixed-case: " + string.Join("  ", mixed));
            Console.Write("Upper-case: " + string.Join(" ", uppercase));
        }

    }
}
