using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern {
	public  class BigTrouser:Finery {

		public override void Show()
		{
			Console.WriteLine("穿大裤衩");
			base.Show();
		}
	}
}
