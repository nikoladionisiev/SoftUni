﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Person
{
    public class Person
    {

        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

       public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public virtual int Age
        {
            get
            {
                return this.age;
            }
             set
            {
                if (value < 0)
                {
                    throw new ArgumentException("invalid age!");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));
            return stringBuilder.ToString().TrimEnd();
        }
    }
}
