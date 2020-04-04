using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Border_Control
{
    class Citizen : IIdentifable
    {
        private string name;
        private int age;

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string ID { get; private set; }
    }
}
