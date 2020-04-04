using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Border_Control
{
    class StartUp
    {
        static void Main()
        {
           
            List<IIdentifable> list = new List<IIdentifable>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split('-', ' ').ToArray();

                if (input.Length == 3)
                {
                    list.Add(new Citizen(input[0], int.Parse(input[1]), input[2]));
                }
                else if (input.Length == 2)
                {
                    list.Add(new Robot(input[0], input[1]));
                }

            }

            string lastDigit = Console.ReadLine();

            list.Where(c => c.ID.EndsWith(lastDigit)).Select(c => c.ID).ToList().ForEach(Console.WriteLine);
        }
    }
}
