﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite.Contracts
{
    public interface IRepair
    {
        string PartName { get; }

        int HoursWorked { get; }
    }
}
