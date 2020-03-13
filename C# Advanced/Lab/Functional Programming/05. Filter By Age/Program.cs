using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> dict = new Dictionary<string, int>();

            int age = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                string name = input[0];
                age = int.Parse(input[1]);

                dict[name] = age;

            }

            string oldYoung = Console.ReadLine();
            int givenAge = int.Parse(Console.ReadLine());
            string nameAge = Console.ReadLine();

            if (oldYoung == "older")
            {
                foreach (var item in dict.Where(x => x.Value >= givenAge))
                {
                    if (nameAge == "name age")
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                    else if (nameAge == "name")
                    {

                        Console.WriteLine(item.Key);
                    }

                    else if (nameAge == "age")
                    {

                        Console.WriteLine(item.Value);

                    }
                }
            }

            else if (oldYoung == "younger")
            {
                foreach (var item in dict.Where(x => x.Value < givenAge))
                {
                    if (nameAge == "name age")
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                    else if (nameAge == "name")
                    {

                        Console.WriteLine(item.Key);
                    }

                    else if (nameAge == "age")
                    {

                        Console.WriteLine(item.Value);

                    }
                }
            }
        }
    }
}
