using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern {
	class Program {
		static void Main(string[] args) {
			ConcreteMediator mediator = new ConcreteMediator();

			ConcreteColleague1 c1 = new ConcreteColleague1(mediator);

			ConcreteColleague2 c2 = new ConcreteColleague2(mediator);

			mediator.Colleague1 = c1;
			mediator.Colleague2 = c2;

			c1.Send("hi, how are you?");
			c2.Send("I'm fine, thank you.");
		}
	}
}
