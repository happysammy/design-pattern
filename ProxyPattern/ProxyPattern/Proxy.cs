using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern {

	//代理类和具体的实体都要遵循同一套接口
	public  class Proxy:Subject
	{
		private ConcreteSubject subject ;
		public override void Request()
		{
			if (subject == null)
			{
				subject = new ConcreteSubject();
			}

			subject.Request();
		}
	}
}
