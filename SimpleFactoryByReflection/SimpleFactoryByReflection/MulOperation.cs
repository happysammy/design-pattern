using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryByReflection {
	public class MulOperation :Operation {
		public override int GetResult()
		{
			return NumberA*NumberB;
		}
	}
}
