using System;
using System.Collections.Generic;
using System.Text;

namespace _4._Hotel_Reservation
{
    class Calculator
    { 
        public static decimal Calculate(decimal pricePerDay, int days, Season season, Discount discount)
        {
            return (pricePerDay * days * (int)season) * (1 - (decimal)discount / 100);
        }
    }
}
