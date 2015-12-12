using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern {
	public abstract  class Iterator
	{

		public abstract object First();
		public abstract object MoveNext();
		public abstract bool IsDone();

		public abstract object CurrentItem();

	}
}
