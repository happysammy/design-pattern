using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern {
	public class Originator
	{
		//创建备忘录 以及恢复备忘录状态

		private string _state;

		public string State
		{
			get { return _state; }
			set { _state = value; }
		}

		public Memento CreateMemento()
		{
			return new Memento(_state);
		}

		public void SetMemento(Memento m)
		{
			_state = m.State;
		}

		public void Show()
		{
			Console.WriteLine("当前状态是{0}",_state);
		}
	}
}
