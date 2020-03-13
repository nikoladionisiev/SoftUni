using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Define_a_Class_Person
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public override string ToString()
        {
            return $"Account age {this.Age}, name {this.Name}";
        }
    }
}
