using _07._Military_Elite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite.Models
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public string PartName {get; private set;}
                              
        public int HoursWorked { get; private set; }
    }
}
