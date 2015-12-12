using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern {
	public  class ConcreteClassB :AbstractClass{
		public override void MethodA()
		{
			Console.WriteLine("MethodA in concreteClassB");
		}

		public override void MethodB()
		{
			Console.WriteLine("MethodB in concreteClassB");
		}
	}
}
