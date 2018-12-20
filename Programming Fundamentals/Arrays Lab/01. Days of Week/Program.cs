using System;

namespace _01._Days_of_Week
{
    class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (number > 0 && number < 8)
            {
                Console.WriteLine(dayOfWeek[number - 1]);
            }

            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
