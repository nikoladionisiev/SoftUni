using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Pizza_Calories
{
    class Pizza
    {
        private string name;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.toppings = new List<Topping>();
            this.Name = name;
            this.Dough = dough;
        }

        private Dough Dough { get; }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length > 15 || value.Length < 1)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols");
                }
                name = value;
            }
        }

        public int ToppingsCount => toppings.Count;

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count == 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }
            this.toppings.Add(topping);
        }

        public double Result()
        {
            double result = this.Dough.DoughCalories() + this.toppings.Sum(x => x.ToppingCalories());
            return result;
        }

    }
}
