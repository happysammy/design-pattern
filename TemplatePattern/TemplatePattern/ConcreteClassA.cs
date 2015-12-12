using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern {
	public  class ConcreteClassA:AbstractClass {
		public override void MethodA()
		{
			Console.WriteLine("MethodA in concreteClassA");
		}

		public override void MethodB()
		{
			Console.WriteLine("MethodB in concreteClassA");
		}
	}
}
