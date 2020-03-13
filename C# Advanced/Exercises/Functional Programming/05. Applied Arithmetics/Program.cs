using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Func<List<int>,List<int>> addition = nums => nums.Select(x => x + 1).ToList();
            Func<List<int>, List<int>> multiplication = nums => nums.Select(x => x * 2).ToList();
            Func<List<int>, List<int>> subtraction = nums => nums.Select(x => x - 1).ToList();



            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                if (input == "add")
                {
                    numbers = addition(numbers);
                }
                else if (input == "multiply")
                {
                    numbers = multiplication(numbers);
                }
                else if (input == "subtract")
                {
                    numbers = subtraction(numbers);
                }
                else if (input == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
                
            }
        }
    }
}
