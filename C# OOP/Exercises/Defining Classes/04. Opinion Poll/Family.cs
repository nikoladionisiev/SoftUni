using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Opinion_Poll
{
    class Family
    {
        private List<Person> members;

        public Family()
        {
            this.Members = new List<Person>();
        }

        public List<Person> Members
        {
            get { return this.members; }
            set { this.members = value; }
        }

        public void AddMember(Person person)
        {
            this.Members.Add(person);

        }
    }
}
