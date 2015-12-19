using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern {
	class Program {
		static void Main(string[] args) {
			Receiver r = new Receiver();
			Command c = new ConcreteCommmand(r);

			Invoker i = new Invoker();
			i.SetCommand(c);
			i.ExecuteCommand();
		}
	}
}
