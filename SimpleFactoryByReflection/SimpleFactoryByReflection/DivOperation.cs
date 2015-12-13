using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryByReflection {
	public class DivOperation:Operation {
		public override int GetResult()
		{
			if (NumberB == 0)
			{
				throw new  Exception("除数不能为0");
			}

			return NumberA/NumberB;
		}
	}
}
