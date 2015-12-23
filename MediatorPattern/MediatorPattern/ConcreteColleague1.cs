using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern {
	public  class ConcreteColleague1:Colleague {
		public ConcreteColleague1(Mediator mediator):
			base(mediator)
		{
			
		}
		public override void Send(string message) {
			mediator.Send(message,this);
		}

		public override void Notify(string message) {
			Console.WriteLine("同事1得到消息"+message);
		}
	}
}
