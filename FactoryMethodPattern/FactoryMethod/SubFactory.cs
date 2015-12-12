using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod {
	public  class SubFactory:IFactory {

		public Operation CreateOperation()
		{
			return new SubOperation();
		}
	}
}
