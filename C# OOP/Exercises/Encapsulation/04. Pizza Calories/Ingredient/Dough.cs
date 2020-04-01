using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Pizza_Calories
{
    public class Dough
    {
        private const int BaseCaloriesPerGram = 2;

        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;

        }

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set
            {
                if (value != "Crispy" && value != "Chewy" && value != "Homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }

        public string FlourType
        {
            get { return flourType; }
            private set
            {
                if (value != "White" && value != "Wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value;
            }
        }

        public int Weight
        {
            get { return this.weight; }

            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public double DoughCalories()
        {
            return (BaseCaloriesPerGram * this.Weight) * FlourModifier() * TechniqueModifier();
        }

        private double TechniqueModifier()
        {
            if (this.BakingTechnique == "Crispy")
            {
                return 0.9;
            }
            else if (this.BakingTechnique == "Chewy")
            {
                return 1.1;
            }
            else
            {
                return 1.0;
            }
        }

        private double FlourModifier()
        {
            if (this.FlourType == "White")
            {
                return 1.5;
            }
            else
            {
                return 1.0;
            }

        }

    }
}
