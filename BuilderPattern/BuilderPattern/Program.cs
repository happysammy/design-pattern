using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern {
	class Program {
		static void Main(string[] args) {

			Builder builder = new ConcreteBuilder2();
			Construct.Constructor(builder);
			Product p = builder.GetResult();
			p.Show();
		}
	}
}
