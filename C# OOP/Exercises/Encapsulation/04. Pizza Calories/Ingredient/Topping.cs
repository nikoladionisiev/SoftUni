using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Pizza_Calories
{
    public class Topping
    {
		private const int BaseCaloriesPerGram = 2;

		private string toppingType;
		private double weight;

		public Topping(string toppingType, double weight)
		{
			this.ToppingType = toppingType;
			this.Weight = weight;
		}

		public double Weight
		{
			get { return weight; }
			private set 
			{
				if (value < 1 || value > 50)
				{
					
					throw new Exception($"{value} weight should be in the range [1..50].");
				}

				this.weight = value;
			}
		}

		public string ToppingType
		{
			get { return toppingType; }
			private set 
			{
				if (value != "Meat" && value != "Veggies" && value != "Cheese" && value != "Sauce")
				{	
					throw new Exception($"Cannot place {value} on top of your pizza.");
				}

				this.toppingType = value;
			}
		}

		public double ToppingCalories()
		{
			return BaseCaloriesPerGram * Weight * ToppingTypeModifier();
		}

		private double ToppingTypeModifier()
		{
			if (this.ToppingType == "Meat")
			{
				return 1.2;
			}
			else if (this.ToppingType == "Veggies")
			{
				return 0.8;
			}
			else if (this.ToppingType == "Cheese")
			{
				return 1.1;
			}
			else
			{
				return 0.9;
			}
		}
	}
}
