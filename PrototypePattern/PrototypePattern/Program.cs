using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern {
	class Program {
		static void Main(string[] args) {
			ConcretePrototype1 p1= new ConcretePrototype1("M");
			ConcretePrototype1 p2 = (ConcretePrototype1) p1.Clone();
			Console.WriteLine("Id is {0}",p2.Id);
		}
	}
}
