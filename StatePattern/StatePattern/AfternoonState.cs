using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern {
	public class AfternoonState:State {
		public override void WriteProgram(Work w)
		{
			if (w.Hour<17)
			{
				Console.WriteLine("当前时间是{0},下午工作状态",w.Hour);
			}
			else
			{
				w.SetState(new EveningState());
				w.WriteProgram();
			}
		}
	}
}
