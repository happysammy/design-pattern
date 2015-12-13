using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern {
	public class Facade
	{

		private SubSystemOne sysOne=null;
		private SubSystemTwo  sysTwo=null;
		private  SubSystemThree sysThree=null;

		public Facade()
		{
			this.sysOne= new SubSystemOne();
			this.sysTwo=new SubSystemTwo();
			this.sysThree=new SubSystemThree();
		}

		public void MethodA()
		{
			Console.WriteLine("方法组A如下：");
			sysOne.MethodOne();
			sysTwo.MethodTwo();
		}

		public void MethodB()
		{
			Console.WriteLine("方法组B如下:");
			sysTwo.MethodTwo();
			sysThree.MethodThree();
		}
	}
}
