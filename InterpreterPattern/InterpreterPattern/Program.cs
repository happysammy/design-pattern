using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern {
	class Program {
		//将演奏文本"T 500 O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 A 0.5 O 3 C 1 O 2 G 1 D 3"
		//按照音符 音阶 音速三大类来翻译
		static void Main(string[] args) {

			PlayContext context = new PlayContext();
			Console.WriteLine("翻译结果如下：");
			context.PlayText = "T 500 O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 A 0.5 O 3 C 1 O 2 G 1 D 3 ";
			Expression expression = null;
			try
			{
				while (context.PlayText.Length>0)
				{
					string str = context.PlayText.Substring(0, 1);
					switch (str)
					{
						case "O":
							expression=new Scale();
							break;
						case "C":
						case "D":
						case "E":
						case "F":
						case "G":
						case "A":
						case "B":
							expression=new Note();
							break;
						case "T":
							expression=new Speed();
							break;
					}
					expression.Interpret(context);
				}

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
