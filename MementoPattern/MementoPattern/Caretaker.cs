using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern {
	public class Caretaker
	{
		//保存备忘录

		private Memento _memento;

		public Memento Memmento
		{
			get { return _memento;}
			set { _memento = value; }
		}
	}
}
