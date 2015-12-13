using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryByReflection {
	public static  class OperationFactory {

		public static Operation CreateOperation(string operationName)
		{
			//reflection,not switch case
			Assembly currentAssembly = Assembly.GetExecutingAssembly();
			var currentType = currentAssembly.GetTypes().SingleOrDefault(t => t.Name == operationName);
			return (Operation)Activator.CreateInstance(currentType);

		}
	}
}
