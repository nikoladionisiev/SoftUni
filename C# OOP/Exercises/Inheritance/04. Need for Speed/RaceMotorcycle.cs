using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Need_for_Speed
{
    class RaceMotorcycle : Motorcycle
    {
        private const double defaultFuelConsumtion = 8;

        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override double fuelConsumtion => defaultFuelConsumtion;
    }
}
