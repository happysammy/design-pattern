﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern {
	public  class ConcretePrototype1 :Prototype{

		public ConcretePrototype1(string id) : base(id)
		{
			
		}
		public override Prototype Clone()
		{
			//shadow copy
			return (Prototype)this.MemberwiseClone();
		}
	}
}
