using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern {
	public  class CashRebate: CashSuper
	{

		private double moneyRebate = 1d;

		public CashRebate(string param)
		{
			this.moneyRebate = double.Parse(param);
		}
		public override double AcceptCash(double money)
		{
			return money*moneyRebate;
		}
	}
}
