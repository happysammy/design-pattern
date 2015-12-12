using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern {
	class Program {
		static void Main(string[] args) {

			MobileBrand brand = new Apple();
			brand.SetSoftWare(new AddressBook());
			brand.Run();
		}
	}
}
