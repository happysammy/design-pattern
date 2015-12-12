using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton {
	class Program {
		static void Main(string[] args) {
			Single s1 =Single.GetInstance();
			Single s2= Single.GetInstance();
			if (s1 == s2)
			{
				Console.WriteLine("ok");
			}

		}
	}
}
