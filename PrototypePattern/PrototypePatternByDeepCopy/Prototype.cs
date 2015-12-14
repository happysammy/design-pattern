using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternByDeepCopy {
	public abstract class Prototype {
		//既有值类型的属性，又有引用类型的属性
		public string Id;
		public ClassA EmbedObj;

		public Prototype(string id) {
			this.Id = id;
		}

		public Prototype() { }
	
		public abstract Prototype Clone();
	}
}
