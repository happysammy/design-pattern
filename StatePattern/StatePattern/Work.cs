using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern {
	public  class Work {
		private State current;

		private double hour;

		private bool isFinished=false;

		public Work()
		{
			this.current= new MorningState();
		}

		public bool TaskFinish
		{
			get { return isFinished; }
			set { isFinished = value; }
		}

		public double Hour
		{
			get { return hour; }
			set { hour = value; }
		}

		public void SetState(State s)
		{
			current = s;
		}

		public void WriteProgram()
		{
			current.WriteProgram(this);
		}

		
	}
}
