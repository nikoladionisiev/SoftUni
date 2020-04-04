using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Cars
{
    interface ICar
    {
        string Model { get; }

        string Color { get; }

        string Start();

        string Stop();
    }
}
