using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern {
	public class ConcreteColleague2 :Colleague{

		public ConcreteColleague2(Mediator mediator):
			base(mediator)
		{
			
		}
		public override void Send(string message)
		{
			mediator.Send(message,this);
		}

		public override void Notify(string message)
		{
			Console.WriteLine("同事2得到信息"+message);
		}
	}
}
