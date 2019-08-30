using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace _08._Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = new SortedDictionary<string, Student>();

            //date
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of dates")
                {
                    break;
                }
               
                string[] info = input.Split(' ', ',');
                string name = info[0];

                var student = new Student();
                student.Dates = new List<DateTime>();
                student.Comments = new List<string>();

                for (int i = 1; i < info.Length; i++)
                {
                    student.Dates.Add(DateTime.ParseExact(info[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }

                if (summary.ContainsKey(name))
                {
                    for (int i = 1; i < info.Length; i++)
                    {
                        summary[name].Dates.Add(DateTime.ParseExact(info[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                   
                }
                else
                {
                    summary[name] = student;
                }

               
                
            }

            //comments
            while (true)
            {
                string[] input = Console.ReadLine().Split('-');

                if (input[0] == "end of comments")
                {
                    break;
                }

                string com = input[1];

                string nameOfStudent = input[0];

                if (summary.ContainsKey(nameOfStudent))
                {
                    
                    summary[nameOfStudent].Comments.Add(com); 
                    
                }
                else
                {
                    continue;
                }

               
            }

            foreach (var person in summary)
            {
                Console.WriteLine(person.Key);
                Console.WriteLine("Comments:");

                if (person.Value.Comments != null)
                {
                    foreach (var comments in person.Value.Comments)
                    {
                        Console.WriteLine("- " + comments);
                    }
                }
               
                Console.WriteLine("Dates attended:");
                foreach (var date in person.Value.Dates.OrderBy(x => x.Date))
                {
                    Console.WriteLine("-- " + date.ToString("dd/MM/yyyy"));
                }

            }
          
           
        }
    }

}
