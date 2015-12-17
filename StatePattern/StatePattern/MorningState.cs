using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern {
	public class MorningState :State
	{
		public override void WriteProgram(Work w)
		{
			if (w.Hour < 12)
			{
				Console.WriteLine("当前时间是{0},上午工作状态",w.Hour);
			}
			else
			{
				w.SetState(new NoonState());
				w.WriteProgram();
			}
		}
	}
}
