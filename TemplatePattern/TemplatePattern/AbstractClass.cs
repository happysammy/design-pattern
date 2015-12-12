using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern {
	public abstract class AbstractClass
	{

		public abstract void MethodA();
		public abstract void MethodB();


		public void TemplateMethod()
		{
			MethodA();
			MethodB();
		}
	}
}
