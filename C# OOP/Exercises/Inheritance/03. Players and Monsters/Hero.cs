using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Players_and_Monsters
{
    abstract class Hero
    {
		private string username;
		private int level;

		public Hero(string username, int level)
		{
			this.Username = username;
			this.Level = level;
		}

		public int Level
		{
			get { return level; }
			set { level = value; }
		}

		public string Username
		{
			get { return username; }
			set { username = value; }
		}

		public override string ToString()
		{
			return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
		}
	}
}
