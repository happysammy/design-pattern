using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern {
	public  abstract  class Colleague
	{

		protected Mediator mediator;

		public Colleague(Mediator mediator)
		{
			this.mediator = mediator;
		}

		public abstract void Send(string message);
		public abstract void Notify(string message);
	}
}
