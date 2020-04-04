using _07._Military_Elite.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite.Contracts
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
