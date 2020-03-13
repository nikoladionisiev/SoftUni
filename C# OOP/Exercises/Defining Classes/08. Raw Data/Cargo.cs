using System;
using System.Collections.Generic;
using System.Text;

namespace _08._Raw_Data
{
    class Cargo
    {
        //<CargoWeight> <CargoType> 
        private int cargoWeight;
        private string cargoType;

        public Cargo(int cargoWeight, string cargoType)
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }

        public string CargoType
        {
            get { return cargoType; }
            set { cargoType = value; }
        }
        public int CargoWeight
        {
            get { return cargoWeight; }
            set { cargoWeight = value; }
        }

    }
}
