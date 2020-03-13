using System;
using System.Collections.Generic;

namespace _10._Car_Salesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                //<Model> <Power> <Displacement> <Efficiency>”
                string model = input[0];
                double power = double.Parse(input[1]);
                string displacement;
                string efficiency;

                if (input.Length == 3)
                {
                    displacement =input[2];
                    Engine engine = new Engine(model, power, displacement);
                    engines.Add(engine);
                }
                else if (input.Length == 4)
                {
                    displacement = input[2];
                    efficiency = input[3];
                    Engine engine = new Engine(model, power, displacement, efficiency);
                    engines.Add(engine);
                }
                else
                {
                    Engine engine = new Engine(model, power);
                    engines.Add(engine);
                }
               
            }

            int m = int.Parse(Console.ReadLine());

            //“<Model> <Engine> <Weight> <Color>”

            List<Car> cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                string e = input[1];
                double weight = double.Parse(input[2]);
                string color = input[3];

                Engine engine = engines.Find(x => x.Model == e);

                Car car = new Car(model, engine, weight, color);
                cars.Add(car);
            }
            foreach (var engine in engines)
            {
                Console.WriteLine(engine);
            }

        }
    }
}
