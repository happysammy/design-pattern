using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject_Observer {
	public class ComeBackEventArgs:EventArgs
	{
		public string Status;

		public ComeBackEventArgs(string param)
		{
			this.Status = param;
		}
	}
}
