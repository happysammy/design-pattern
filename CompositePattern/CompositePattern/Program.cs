using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern {
	class Program {
		static void Main(string[] args) {

			ConcreteCompany root = new ConcreteCompany("北京总公司");
			root.Add(new HRDepartment("总公司人力资源部"));
			root.Add((new FinanceDepartment("总公司财务部")));

			ConcreteCompany comp = new ConcreteCompany("上海分公司");
			comp.Add(new HRDepartment("上海分公司人力资源部"));
			comp.Add(new FinanceDepartment("上海分公司财务部"));

			root.Add(comp);

			root.Display(1);
			root.Duty();
			Console.ReadKey();
		}
	}
}
