using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> index = Console.ReadLine().Split().Select(double.Parse).ToList();

            index.Sort();
            Console.Write(string.Join(" <= ", index) + "\n" );
           
        }
    }
}
