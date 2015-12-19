using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern {
	 public  class ConcreteCommmand :Command{

		public ConcreteCommmand(Receiver receiver) : base(receiver)
		{
			
		}

		 public override void Execute()
		 {
			 receiver.Action1();
		 }
	 }
}
