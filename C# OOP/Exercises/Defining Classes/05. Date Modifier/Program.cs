using System;

namespace _05._Date_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DateTime firstDate;
            firstDate = DateTime.Parse(Console.ReadLine());

            DateTime secondDate;
            secondDate = DateTime.Parse(Console.ReadLine());

            if (firstDate > secondDate)
            {
                Console.WriteLine(firstDate.Subtract(secondDate).TotalDays);
            }
            else
            {
                Console.WriteLine(secondDate.Subtract(firstDate).TotalDays);
            }

           
        }
    }
}
