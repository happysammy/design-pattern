using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern {
	public class ConcreteCompany:Company {
		private  List<Company> children = new List<Company>(); 
		public  ConcreteCompany(string name):base(name) { }

		public override void Remove(Company c)
		{
			children.Remove(c);
		}

		public override void Add(Company c)
		{
			children.Add(c);
		}

		public override void Display(int depth)
		{
			Console.WriteLine(new String('-',depth)+Name);
			foreach (Company item in children) {
				item.Display(depth+2);

			}
		}

		public override void Duty()
		{
			foreach (Company c in children)
			{
					c.Duty();
			}
			
		}
	}
}
