using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject_Observer {
	interface Subject
	{
		void Notify();

		string Status { get; set; }
		
	}
}
