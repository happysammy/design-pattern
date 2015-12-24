using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern {
	class Program {
		static void Main(string[] args) {
			WebsiteFactory factory = new WebsiteFactory();

			User u1= new User("张三");
			Website w1 = factory.GetWebSiteCategory("ProductShow");
			w1.Use(u1);

			User u2 = new User("李四");
			Website w2 = factory.GetWebSiteCategory("ProductShow");
			w2.Use(u2);

			User u3=new User("王五");
			Website w3 = factory.GetWebSiteCategory("Blog");
			w3.Use(u3);

		}
	}
}
