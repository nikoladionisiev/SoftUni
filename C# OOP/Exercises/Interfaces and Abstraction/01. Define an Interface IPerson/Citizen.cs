using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Define_an_Interface_IPerson
{
    class Citizen : IPerson
    {
        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }


    }
}
