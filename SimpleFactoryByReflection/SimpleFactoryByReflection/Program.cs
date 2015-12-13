using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryByReflection {
	class Program {
		static void Main(string[] args)
		{

			Operation op = OperationFactory.CreateOperation("MulOperation");
			op.NumberA = 1;
			op.NumberB = 2;
			Console.WriteLine(op.GetResult());
		}
	}
}
