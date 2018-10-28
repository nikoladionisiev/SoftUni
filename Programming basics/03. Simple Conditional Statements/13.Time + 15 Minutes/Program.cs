using System;

namespace _13.Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int minutesPlus15 = minutes + 15;

            if (hours >= 0 && hours <= 23 && minutesPlus15 >= 60)
            {
                hours++;

                if (hours == 24)
                {
                    hours = 0;
                }

                minutes = (minutesPlus15) % 60;

                Console.WriteLine("{0}:{1}", hours, minutes.ToString().PadLeft(2, '0'));
            }

            else
            {
                minutes = (minutesPlus15) % 60;

                Console.WriteLine("{0}:{1}", hours, minutes.ToString().PadLeft(2, '0'));
            }
        }
    }
}
