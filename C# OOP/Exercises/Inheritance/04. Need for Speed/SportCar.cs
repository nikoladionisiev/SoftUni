using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Need_for_Speed
{
    class SportCar : Vehicle
    {
        private const double defaultFuelConsumtion = 10;

        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override double fuelConsumtion => defaultFuelConsumtion;
    }
}
