using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod {
	class Program {
		static void Main(string[] args) {

			IFactory factory = new AddFactory();
			Operation operation = factory.CreateOperation();
			operation.NumberA = 10;
			operation.NumberB = 20;
			Console.WriteLine("The result is {0}",operation.GetResult());
		}
	}
}
