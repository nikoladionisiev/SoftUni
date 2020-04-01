using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Need_for_Speed
{
    class Car : Vehicle
    {
        private const double defaultFuelConsumption = 3;

        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override double fuelConsumtion => defaultFuelConsumption;
    }
}
