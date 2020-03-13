using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vips = new HashSet<string>();
            HashSet<string> guests = new HashSet<string>();


            string entry = Console.ReadLine();

            while (entry?.ToLower() != "party")
            {
                if (Char.IsDigit(entry[0]))
                {
                    vips.Add(entry);
                }
                else
                {
                    guests.Add(entry);
                }
                entry = Console.ReadLine();
            }

            entry = Console.ReadLine();

            while (entry?.ToLower() != "end")
            {
                if (Char.IsDigit(entry[0]))
                {
                    vips.Remove(entry);
                }
                else
                {
                    guests.Remove(entry);
                }

                entry = Console.ReadLine();
            }

            Console.WriteLine(guests.Count + vips.Count);

            

            foreach (var guest in vips)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);        
            }
        }
    }
}
