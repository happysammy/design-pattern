using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern {
	public abstract class MobileBrand
	{
		protected MobileSoftWare soft;

		public void SetSoftWare(MobileSoftWare soft)
		{
			this.soft = soft;
		}

		public abstract void Run();
	}
}
