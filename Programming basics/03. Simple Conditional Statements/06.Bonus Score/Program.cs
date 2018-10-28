using System;

namespace _06.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            int num = int.Parse(Console.ReadLine());

            double bonusScore = 0.0;

            if (num <= 100)
            {
                bonusScore = 5.0;
            }

            else if (num > 100 && num < 1000)
            {
                bonusScore = num * (20.0 / 100);

            }

            else if (num > 1000)
            {
                bonusScore = num * (10.0 / 100);
            }

            if (num % 2 == 0)
            {
                bonusScore += 1.0;
            }

            else if (num % 10 == 5)
            {
                bonusScore += 2.0;
            }

            Console.WriteLine(bonusScore);
            Console.WriteLine(bonusScore + num);
        }
    }
}
