using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern {
	public class EveningState:State {
		public override void WriteProgram(Work w)
		{
			if (w.TaskFinish)
			{
				w.SetState(new RestState());
				w.WriteProgram();
			}
			else
			{
				if (w.Hour < 21)
				{
					Console.WriteLine("当前时间是{0},加班",w.Hour);
				}
				else
				{
					w.SetState(new SleepingState());
					w.WriteProgram();
				}
			}
		}
	}
}
