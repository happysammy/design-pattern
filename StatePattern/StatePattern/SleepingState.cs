using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern {
	public class SleepingState:State {
		public override void WriteProgram(Work w)
		{
			Console.WriteLine("当前时间是{0}，睡觉",w.Hour);
		}
	}
}
