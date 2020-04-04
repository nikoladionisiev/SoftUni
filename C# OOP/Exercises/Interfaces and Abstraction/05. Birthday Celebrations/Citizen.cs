using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Birthday_Celebrations
{
    class Citizen : IIdentifable, IBirthable
    {
        private string name;
        private int age;

        public Citizen(string name, int age, string id, string date)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
            this.Birthdate = DateTime.ParseExact(date, "dd/mm/yyyy", null);
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

        public DateTime Birthdate { get; private set; }
    }
}
