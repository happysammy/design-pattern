using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject_Observer {
	public  class Boss :Subject
	{
		
		private string _status;

		public string Status
		{
			get { return _status; }

			set { _status = value; }
		}

		public Boss(string status)
		{
			this._status = status;
		}

		public event EventHandler UpDate;

		public void Notify()
		{
			if (UpDate != null)
			{
				ComeBackEventArgs e = new ComeBackEventArgs(_status);
				UpDate(this, e);
			}
		}
	}
}
