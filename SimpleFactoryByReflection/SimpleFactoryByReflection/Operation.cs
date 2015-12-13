using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryByReflection {
	public abstract  class Operation
	{
		public int NumberA=0;
		public int NumberB=0;
		public abstract int GetResult();

	}
}
