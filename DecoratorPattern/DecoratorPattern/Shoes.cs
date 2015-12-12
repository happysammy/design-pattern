using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern {
	public class Shoes:Finery {

		public override void Show()
		{
			Console.WriteLine("穿鞋");
			base.Show();
		}
	}
}
