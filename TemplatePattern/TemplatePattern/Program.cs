using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern {
	class Program {
		static void Main(string[] args) {

			AbstractClass c1 = new ConcreteClassA();
			c1.TemplateMethod();
			
		}
	}
}
