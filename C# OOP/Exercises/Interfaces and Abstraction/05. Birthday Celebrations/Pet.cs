using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Birthday_Celebrations
{
    class Pet : IBirthable
    {
		private string name;

		public Pet(string name, string date)
		{
			this.Name = name;
			this.Birthdate = DateTime.ParseExact(date, "dd/mm/yyyy", null);
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public DateTime Birthdate { get; private set; }
	}
}
