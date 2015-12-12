using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern {
	public class CashContext {

		private CashSuper super;

		public CashContext(string type) {
			switch (type) {
				case "normal":
					super = new CashNormal();
					break;
				case "rebate":
					super = new CashRebate("0.8");
					break;
				case "return":
					super = new CashReturn("300","100");
					break;
			}
		}

		public double GetResult(double money) {
			return super.AcceptCash(money);
		}
	}
}
