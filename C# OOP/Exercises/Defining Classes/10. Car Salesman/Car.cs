using System;
using System.Collections.Generic;
using System.Text;

namespace _10._Car_Salesman
{
    class Car
    {
        private string model;
        private Engine engine;
        private double weight;
        private string color;

        public Car(string model, Engine engine, double weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

    }
}
