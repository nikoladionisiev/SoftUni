using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line of input you will receive a number N - the amount of cars you have.
            int n = int.Parse(Console.ReadLine());

            //On each of the next N lines you will receive an information about a car in the format “<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType> <Tire1Pressure> <Tire1Age> <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age> <Tire4Pressure> <Tire4Age>” where the speed, power, weight and tire age are integers, tire preassure is a double. 

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                List<Tire> tires = new List<Tire>();

                for (int j = 0; j < 4; j += 2)
                {
                    double tirePressure = double.Parse(input[5 + j]);
                    int tireAge = int.Parse(input[6 + j]);

                    Tire tire = new Tire(tireAge, tirePressure);
                    tires.Add(tire);
                }

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            //After the N lines you will receive a single line with one of 2 commands: “fragile” or “flamable”.

            string command = Console.ReadLine();

            List<Car> result = new List<Car>();
            //. If the command is “fragile” print all cars whose Cargo Type is “fragile” with a tire whose pressure is  < 1
            if (command == "fragile")
            {
                result = cars.Where(x => x.Cargo.CargoType == "fragile" && x.Tires.Any(t => t.Pressure < 1)).ToList();
            }
            //If the command is “flamable” print all of the cars whose Cargo Type is “flamable” and have Engine Power > 250. 
            else if (command == "flamable")
            {
                result = cars.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.Power > 250).ToList();
            }

            //The cars should be printed in order of appearing in the input.

            foreach (var car in result)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
