using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{

		
			/*			输出两个整数 / 小数的和 / 差 / 积 / 商
			电脑计算并输出：[(23 + 7)x12-8]÷6的小数值（挑战：精确到小数点以后2位）
			想一想以下语句输出的结果：
				int i = 15;
						Console.WriteLine(i++);  15
						i -= 5;
						Console.WriteLine(i);   11
						Console.WriteLine(i >= 10);   ture

						Console.WriteLine("i值的最终结果为：" + i);

						int j = 20;
						Console.WriteLine($"{i}+{j}={i + j}");  11+20=31
						想一想如下代码的结果是什么，并说明原因：
				int a = 10;
						Console.WriteLine(a > 9 && (!(a < 11) || a > 10));  false
						当a为何值时，结果为true？  当a>11时，结果为true
			bool result = (a + 3 > 12) && a < 3.14 * 4 && a != 11;  true
			*/
			/*整数之间的和，……
			 * int num = 4;
			int sam = 2;
			int number = num / sam;
			Console.WriteLine(number);*/


			/*小数之间的和……
			 * float num = 3.5f;
			float sam = 1.9f;
			float number =num * sam;
			Console.WriteLine(number);*/

			/*float sam= ((23 + 7)*12 - 8)/6;
			Console.WriteLine(sam);*/


			/*int a = 10;
			bool result = (a + 3 > 12) && a < 3.14 * 4 && a != 11;
			Console.WriteLine(result);*/
		}
	}
}
