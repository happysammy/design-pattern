using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern {
	public  class ConcreteWebsite:Website
	{
		private string name = "";

		public ConcreteWebsite(string name)
		{
			this.name = name;
		}


		public override void Use(User user)
		{
			Console.WriteLine("网站分类:"+name+",用户:"+user.Name);
		}
	}
}
