using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternByDeepCopy {
	public  class ConcretePrototype1:Prototype {

		public ConcretePrototype1(string id)
			: base(id) {
			this.EmbedObj= new ClassA();

		}

		private ConcretePrototype1(ClassA a)
		{
			this.EmbedObj = (ClassA)a.Clone();
		}

		public ConcretePrototype1() { }
		public override Prototype Clone()
		{
			ConcretePrototype1 obj = new ConcretePrototype1(this.EmbedObj);
			obj.Id = Id;
			return (Prototype)obj;
		}

		public void SetClassA(int valueA)
		{
			EmbedObj.ValueA = valueA;
		}
	}
}
