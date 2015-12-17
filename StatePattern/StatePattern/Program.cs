using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern {
	class Program {
		static void Main(string[] args) {

			Work w = new Work();
			w.Hour = 9;
			w.WriteProgram();

			w.Hour = 12;
			w.WriteProgram();

			w.Hour = 13;
			w.WriteProgram();

			w.Hour = 14;
			w.WriteProgram();

			w.Hour = 17;
			w.TaskFinish = true;
			w.WriteProgram();

			w.Hour = 19;
			w.WriteProgram();

			w.Hour = 22;
			w.WriteProgram();



		}
	}
}
