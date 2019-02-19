using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();
            bool adjacent = true;


            while (adjacent && input.Count > 1)
            {
                Console.WriteLine('y');
                for (int i = 1; i < input.Count; i++)
                {
                    if (input[i] == input[i - 1])
                    {
                        input[i - 1] = input[i] + input[i - 1];
                        input.RemoveAt(i);
                        adjacent = true;
                        break;
                    }
                    else
                    {
                        adjacent = false;
                    }
                }
            }

            Console.WriteLine(string.Join(" ",input));
        }
    }
}
