using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern {
	public  class NoonState:State {
		public override void WriteProgram(Work w)
		{
			if (w.Hour < 13)
			{
				Console.WriteLine("当前时间是{0},午休",w.Hour);
			}
			else
			{
				w.SetState(new AfternoonState());
				w.WriteProgram();
			}
			
		}
	}
}
