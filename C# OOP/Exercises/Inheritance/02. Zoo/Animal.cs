using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Zoo
{
    class Animal
    {
		private string name;

		public Animal(string name)
		{
			this.Name = name;
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

	}
}
