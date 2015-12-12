using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using FactoryMethod;

namespace FactoryMethod {
	public class DivOperation :Operation{
		public override int GetResult()
		{
			return NumberA/NumberB;
		}
	}
}
