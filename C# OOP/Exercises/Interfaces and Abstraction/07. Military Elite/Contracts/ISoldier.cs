﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite.Contracts
{
    public interface ISoldier
    {
         int Id { get; }
         string FirstName { get; }
         string LastName { get; }
    }
}
