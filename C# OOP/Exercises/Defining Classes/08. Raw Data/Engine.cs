using System;
using System.Collections.Generic;
using System.Text;

namespace _08._Raw_Data
{
    class Engine
    {
        //<EngineSpeed> <EnginePower>

        private int speed;
        private int power;

        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Power
        {
            get { return power; }
            set { power = value; }
        }

    }
}
