using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Animals
{
	class Dog : Animal
	{
		public Dog(string name, string food) : base(name, food)
		{
		}

		public override string ExplainSelf()
		{
			return base.ExplainSelf() + Environment.NewLine + "DJAF";
		}
	}
}
