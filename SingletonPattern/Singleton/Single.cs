using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton {
	public class Single {
		public  static  readonly Single  instance =
		new Single();

		private Single()
		{
			
		}

		public static Single GetInstance()
		{
			return instance;
		}

	}
}
