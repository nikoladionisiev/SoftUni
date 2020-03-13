using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Speed_Racing
{
    class Car
    {
        private string model;
        private decimal fuelAmount;
        private decimal fuelConsumption;
        private int distanceTravelled;

        public Car(string model, decimal fuelAmount, decimal fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
        }

        public string Model { get => model; set => model = value; }
        public decimal FuelAmount { get => fuelAmount; set => fuelAmount = value; }
        public decimal FuelConsumption { get => fuelConsumption; set => fuelConsumption = value; }
        public int DistanceTravelled { get => distanceTravelled; set => distanceTravelled = value; }

        public bool Drive(int distance)
        {
            if (distance * FuelConsumption <= FuelAmount)
            {
                FuelAmount -= FuelConsumption * distance;
                DistanceTravelled += distance;
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            return $"{Model} {FuelAmount:F2} {DistanceTravelled}";
        }
    }
}
