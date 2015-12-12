using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern {
	public abstract  class Company
	{

		private string _name;

		public string Name
		{
			get { return _name; } 
			set { _name = value; }
		}

		public Company(string name)
		{
			this._name = name;
		}

		public abstract void Remove(Company c);
		public abstract void Add(Company c);
		public abstract void Display(int depth);
		public abstract void Duty();
	}
}
