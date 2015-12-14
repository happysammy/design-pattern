using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternByDeepCopy {
	class Program {
		static void Main(string[] args)
		{

			ConcretePrototype1 p1 = new ConcretePrototype1("M");
			p1.SetClassA(20);
			ConcretePrototype1 p2 = (ConcretePrototype1)p1.Clone();
			Console.WriteLine("Id is {0},ValueA is {1}", p2.Id,p2.EmbedObj.ValueA);
		}
	}
}
