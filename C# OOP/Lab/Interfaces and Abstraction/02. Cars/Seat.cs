using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Cars
{
    class Seat : Car, ICar
    {
        public Seat(string model, string color) : base(model, color)
        {
        }
    }
}
