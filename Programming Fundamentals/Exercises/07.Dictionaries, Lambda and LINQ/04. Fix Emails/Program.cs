using System;
using System.Collections.Generic;

namespace _04._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();

            int counter = 0;
            string name = "";

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                if (counter % 2 == 0)
                {
                    name = input;
                }
                else
                {
                    emails[name] = input;

                    if (input.EndsWith("us") || input.EndsWith("uk"))
                    {
                        emails.Remove(name);
                    }
                }
                counter++;
            }

            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
