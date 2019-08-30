using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holydays =
            {
                new DateTime(4,1,1),
                new DateTime(4,3,3),
                new DateTime(4,5,1),
                new DateTime(4,5,6),
                new DateTime(4,5,24),
                new DateTime(4,9,6),
                new DateTime(4,9,22),
                new DateTime(4,11,1),
                new DateTime(4,12,24),
                new DateTime(4,12,25),
                new DateTime(4,12,26)
            };

            int counter = 0;
            for (DateTime day = startDate; day <= endDate; day = day.AddDays(1))
            {
                DateTime temporary = new DateTime(4, day.Month, day.Day);

                if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday || holydays.Contains(temporary))
                {
                    continue;
                }
                else
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
