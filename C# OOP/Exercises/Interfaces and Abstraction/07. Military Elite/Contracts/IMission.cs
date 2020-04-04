using _07._Military_Elite.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite.Contracts
{
    public interface IMission
    {
        string CodeName { get; }

        State State { get; }

        void CompleateMission();
    }
}
