using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Creating_Constructors
{
    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age )
        {
            this.name = name;
            this.age = age; 
        }

       
        public override string ToString()
        {
            return $"{this.name} -> {this.age}";
        }
    }
}
