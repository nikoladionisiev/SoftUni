using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Person
{
    class Child : Person
    {
        public Child(string name, int age)
            :base(name, age)
        {

        }

        public override int Age
        {
            get { return base.Age; }

            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Invalid age");
                }

                base.Age = value;
            }
        }
    }
}
