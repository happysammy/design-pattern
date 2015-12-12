using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern {
	public class Program {
		static void Main(string[] args) {
			ConcreteAggregate aggregate = new ConcreteAggregate();
			aggregate[0] = "xiaozhang";
			aggregate[1] = "xiaoli";
			aggregate[2] = "xiaosan";

			ConcreteIterator iterator = new ConcreteIterator(aggregate);

			while (!iterator.IsDone())
			{
				Console.WriteLine("{0}请买票",iterator.CurrentItem());
				iterator.MoveNext();
			}
		}
	}
}
