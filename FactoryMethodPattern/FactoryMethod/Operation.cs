using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod {
	public abstract class Operation
	{
		public int NumberA;
		public int NumberB;

		public  abstract int GetResult();
	}
}
