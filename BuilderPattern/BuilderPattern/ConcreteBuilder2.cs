using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern {
	public  class ConcreteBuilder2:Builder {

		private Product product = new Product();

		public override void BuildPartA() {
			product.Add("PartX");
		}

		public override void BuildPartB() {
			product.Add("PartY");
		}

		public override Product GetResult() {
			return product;
		}
	}
}
