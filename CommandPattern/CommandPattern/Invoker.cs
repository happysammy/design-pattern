using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern {
	public class Invoker
	{
		//如果需要执行多个请求 或取消某个请求 只需设置一个command list

		private Command command;

		public void SetCommand(Command command)
		{
			this.command = command;
		}

		public void ExecuteCommand()
		{
			command.Execute();
		}
	}
}
