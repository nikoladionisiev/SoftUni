using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                cars.Add(new Car(input[0], decimal.Parse(input[1]), decimal.Parse(input[2])));
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split();

                string model = input[1];
                int distance = int.Parse(input[2]);

                Car car = cars.First(c => c.Model == model);

                if (!car.Drive(distance))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            cars.ForEach(Console.WriteLine);

        }
    }
}
