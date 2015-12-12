using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern {
	class Program {
		static void Main(string[] args) {

			Person person = new Person("yuandong");

			Console.WriteLine("\n第一种装扮");

			TShirts t = new TShirts();
			BigTrouser b = new BigTrouser();
			Shoes s = new Shoes();

			t.Decorate(person);
			b.Decorate(t);
			s.Decorate(b);

			s.Show();
		}
	}
}
