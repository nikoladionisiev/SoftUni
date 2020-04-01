using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Need_for_Speed
{
    class Vehicle
    {
		private int horsePower;
		private double fuel;

		private const double defaultFuelConsumption = 1.25;
		public virtual double fuelConsumtion => defaultFuelConsumption; 
		

		public Vehicle(int horsePower, double fuel)
		{
			this.HorsePower = horsePower;
			this.Fuel = fuel;
		}

		public double Fuel
		{
			get { return fuel; }
			set { fuel = value; }
		}

		public int HorsePower
		{
			get { return horsePower; }
			set { horsePower = value; }
		}


		public void Drive(double km)
		{
			bool canDrive = this.Fuel - km * fuelConsumtion >= 0;

			if (canDrive)
			{

			}

			this.Fuel -= km * this.fuelConsumtion;
		}

	}
}
