using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();
           
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!dict.ContainsKey(name))
                {
                    dict[name] = new List<double>(); 
                    dict[name].Add(grade);
                }
                else
                {
                    dict[name].Add(grade);
                }

            }

            foreach (var item in dict)
            {
                string name = item.Key;
                List<double> studentGrades = item.Value;

                var average = studentGrades.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in studentGrades)
                {

                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
