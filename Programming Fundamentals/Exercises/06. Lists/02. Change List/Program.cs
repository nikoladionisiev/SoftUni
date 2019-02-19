using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
           

           
            while (true)
            {

                string line = Console.ReadLine();

                if (line == "Odd")
                {
                    foreach (int number in numbers)
                    {
                        if (number % 2 != 0)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
                else if (line == "Even")
                {
                    foreach (int number in numbers)
                    {
                        if (number % 2 ==0)
                        {
                            Console.Write($"{number} ");
                        }
                    }

                    Console.WriteLine();
                    break;
                }

                string[] tokens = line.Split();

                string command = tokens[0];

                switch (command)
                {
                    case "Delete":
                        int numToRemove = int.Parse(tokens[1]);
                        numbers.RemoveAll(n => n == numToRemove);
                        break;
                    case "Insert":
                        int element = int.Parse(tokens[1]);
                        int position = int.Parse(tokens[2]);
                        numbers.Insert(position, element);
                        break;
                }

               
            }

            
        }
    }
}
