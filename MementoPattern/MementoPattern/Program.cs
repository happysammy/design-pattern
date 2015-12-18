using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern {
	class Program {
		static void Main(string[] args) {
			Originator o = new Originator();
			o.State = "on";
			o.Show();

			Caretaker c = new Caretaker();
			c.Memmento = o.CreateMemento();

			o.State = "off";
			o.Show();

			o.SetMemento(c.Memmento);
			o.Show();
		}
	}
}
