using System;
using System.Collections.Generic;
using System.Text;

namespace _10._Car_Salesman
{
    class Engine
    {
        private string model;
        private double power;
        private string displacement;
        private string efficiency;

        public Engine(string model, double power)
        {
            this.Model = model;
            this.Power = power;
        }
        public Engine(string model, double power, string displacement) :this(model, power)
        {
            this.Displacement = "n/a";
            this.Displacement = displacement;
        }
        public Engine(string model, double power, string displacement, string efficiency) : this(model, power, displacement)
        {
            this.Efficiency = "n/a";
            this.Efficiency = efficiency;
        }
        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }

        public string Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }

        public double Power
        {
            get { return power; }
            set { power = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public override string ToString()
        {
            return $"{Model} - {Power} - {Displacement} - {Efficiency}";
        }
    }
}
