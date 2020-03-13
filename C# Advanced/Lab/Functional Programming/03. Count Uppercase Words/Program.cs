using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in input)
            {
                if (item[0] == item.ToUpper()[0])
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
