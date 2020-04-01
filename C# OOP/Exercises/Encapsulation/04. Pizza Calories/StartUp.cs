using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Pizza_Calories
{
    class StartUp
    {
        static void Main(string[] args)
        {
			try
			{
                string[] input = Console.ReadLine().Trim().Split();

                string pizzaName = input[1];

                input = Console.ReadLine().Trim().Split();

                string flourType = input[1];
                string bakingTechnique = input[2];
                int weight = int.Parse(input[3]);

                Dough dough = new Dough(flourType, bakingTechnique, weight);



                Pizza pizza = new Pizza(pizzaName, dough);


                string toppingType;
                double weightTopping = 0.0;


                while (true)
                {
                    input = Console.ReadLine().Trim().Split();

                    if (input[0] == "END")
                    {
                        break;
                    }

                    toppingType = input[1];
                    weightTopping = double.Parse(input[2]);

                    Topping topping = new Topping(toppingType, weightTopping);

                    pizza.AddTopping(topping);
                }


                Console.WriteLine($"{pizza.Name} - {pizza.Result():F2} Calories.");
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

        }
    }
}
