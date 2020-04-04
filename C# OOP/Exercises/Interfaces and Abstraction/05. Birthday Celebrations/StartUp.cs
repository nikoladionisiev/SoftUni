using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Birthday_Celebrations
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthable> list = new List<IBirthable>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split('-', ' ').ToArray();

                switch (input[0])
                {
                    case "Citizen":
                        list.Add(new Citizen(input[1], int.Parse(input[2]), input[3], input[4]));
                        break;
                    case "Pet":
                        list.Add(new Pet(input[1], input[2]));
                        break;
                }

            }

            int year = int.Parse(Console.ReadLine());

            list.Where(c => c.Birthdate.Year == year).Select(c => c.Birthdate).ToList().ForEach(dt => Console.WriteLine($"{dt:dd/mm/yyyy}"));
        }
    }
}
