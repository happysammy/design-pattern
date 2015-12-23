using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern {
	class Program {
		static void Main(string[] args) {
			//继承者由客户端来设定
			//所有的调用都由h1开始

			Handler h1= new ConcreteHandler1();
			Handler h2 = new ConcreteHandler2();
			Handler h3= new ConcreteHandler3();

			h1.SetSuccessor(h2);
			h2.SetSuccessor(h3);

			int[] requests = {36,2,5,18,24};

			foreach (int request in requests)
			{
				h1.HandleRequest(request);
			}
		}
	}
}
