using System;

namespace _4._Hotel_Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            //“<pricePerDay> <numberOfDays> <season> <discountType>”, where:
            decimal pricePerDay = decimal.Parse(input[0]);
            int numberOfDays = int.Parse(input[1]);
            Enum.TryParse(input[2], out Season season);
            Enum.TryParse(input[3], out Discount discount);

            Console.WriteLine($"{Calculator.Calculate(pricePerDay, numberOfDays, season, discount) :F2}");
           
        }
    }
}
    