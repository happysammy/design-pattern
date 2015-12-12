using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject_Observer {
	public class StockObserver
	{
		private string _name;
		
		public StockObserver(string name)
		{
			this._name = name;
			
		}

		public void OnStockClose(object sender, EventArgs args)
		{
			Console.WriteLine("{0},{1}关闭股票查看",((ComeBackEventArgs)args).Status,_name);
		}
	}
}
