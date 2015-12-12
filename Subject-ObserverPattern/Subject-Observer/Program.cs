using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject_Observer {
	class Program {
		static void Main(string[] args) {
			NBAObserver tongshi1 = new NBAObserver("yuandong1");
			StockObserver tongshi2=new StockObserver("yuandong2");

			Boss boss = new Boss("huhanshan come back ");
			boss.UpDate += tongshi1.OnNBAClose;
			boss.UpDate += tongshi2.OnStockClose;
			boss.Notify();
			;

		}
	}
}
