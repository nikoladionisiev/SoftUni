using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Border_Control
{
    class Robot : IIdentifable
    {
		private string model;

		public Robot(string model, string id)
		{
			this.Model = model;
			this.ID = id;
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}


		public string ID { get; private set; }
    }
}
