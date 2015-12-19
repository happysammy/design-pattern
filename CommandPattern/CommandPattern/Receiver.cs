using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern {
	public class Receiver {
		public void Action1()
		{
			Console.WriteLine("执行请求1");
		}

		public void Action2()
		{
			Console.WriteLine("执行请求2");
		}
	}
}
