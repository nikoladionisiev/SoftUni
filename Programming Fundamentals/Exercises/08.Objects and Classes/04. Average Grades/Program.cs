using System;
using System.Linq;
using System.Collections.Generic;
namespace _04._Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var students = new List<Student>();
            

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                Student student = new Student();
                student.name = input[0];

                student.grades = new List<double>();

                for (int j = 1; j < input.Length; j++)
                {

                    student.grades.Add(double.Parse(input[j]));
                }

                student.avarageGrade = student.grades.Average();
                if (student.avarageGrade >= 5.00)
                {
                    students.Add(student);
                }
            }

            
            students = students.OrderByDescending(x => x.avarageGrade).OrderBy(x => x.name).ToList();

            foreach (var item in students)
            {
                Console.WriteLine($"{item.name} -> {item.avarageGrade :F2}");
            }
        }
    }
}
