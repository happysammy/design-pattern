using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern {
	public abstract class Prototype
	{
		//只有值类型的属性，没有引用类型的属性
		public string Id;

		public Prototype(string id)
		{
			this.Id = id;
		}

		public abstract Prototype Clone();
	}
}
