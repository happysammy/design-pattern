using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern {
	public  class Product {

		private List<string> parts = new List<string>();

		public void Add(string part)
		{
			parts.Add(part);
		}

		public void Show()
		{
			foreach (string part in parts)
			{
				Console.WriteLine(part);
			}
		}
	}
}
