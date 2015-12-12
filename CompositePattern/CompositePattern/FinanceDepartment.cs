using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern {
	public  class FinanceDepartment :Company{

		public FinanceDepartment(string name) : base(name) { }

		public override void Remove(Company c){}
		public override void Add(Company c) { }

		public override void Display(int depth)
		{
			Console.WriteLine(new String('-',depth)+Name);
		}

		public override void Duty()
		{
			Console.WriteLine("{0} 公司财务收支管理",Name);
		}
	}
}
