
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternByDeepCopy {
	public class ClassA:ICloneable
	{
		public int ValueA;

	

		public object Clone()
		{
			
			return (object)this.MemberwiseClone();
		}
	}
}
