using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string position = input[2];
                string department = input[3];

                Employee employee = new Employee(name, salary, position, department);

                if (input.Length == 5)
                {
                    if (input[4].Contains('@'))
                    {
                        employee.Email = input[4];
                    }
                    else
                    {
                        int age = int.Parse(input[5]);
                        employee.Age = age;
                    }
                }
                else if (input.Length == 6)
                {
                    int age = int.Parse(input[5]);
                    employee.Email = input[4];
                    employee.Age = age; 
                }

                employees.Add(employee);
            }

            var topDepartment = employees.GroupBy(x => x.Department)
                                         .ToDictionary(x => x.Key, y => y.Select(s => s))
                                         .OrderByDescending(x => x.Value.Average(s => s.Salary))
                                         .FirstOrDefault();

            Console.WriteLine($"Highest Avarage Salary {topDepartment.Key}");

            foreach (var item in topDepartment.Value.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{item.Name} {item.Salary :F2} {item.Email} {item.Age}");
            }
        }
    }
}
