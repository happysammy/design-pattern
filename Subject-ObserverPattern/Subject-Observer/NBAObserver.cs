using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject_Observer {
	public  class NBAObserver {
		private string _name;
		
		public NBAObserver(string name)
		{
			this._name = name;
			
		}

		public void OnNBAClose(object sender, EventArgs args)
		{
			Console.WriteLine("{0},{1}关闭NBA直播",((ComeBackEventArgs)args).Status,_name);
		}
	}
}
