using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern {
	class Construct {

		public static  void Constructor(Builder builder)
		{
			builder.BuildPartA();
			builder.BuildPartB();
			builder.GetResult();
		}
	}
}
