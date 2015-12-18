using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern {
	public class Memento
	{
		//备忘录类保存originator对象的内部状态（属性）

		private string _state;

		public Memento(string state)
		{
			this._state = state;
		}

		public string State
		{
			get { return _state; }
		}
	}
}
