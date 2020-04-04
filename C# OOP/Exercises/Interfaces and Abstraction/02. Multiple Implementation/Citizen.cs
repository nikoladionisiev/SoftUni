using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Multiple_Implementation
{
    class Citizen : IBirthable, IIdentifiable, IPerson
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Id { get; private set; }

        public string Birthdate { get; private set; }

        public string Name { get; private set; }

        public int Age { get; private set; }
    }
}
