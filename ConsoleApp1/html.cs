using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int num;
			long sam = num;

			/*
		 * 隐式转换
		 * int num = 55;
		long sam = num;
		sam = 99;
		sam = 88;
		sam = 99;
		*/


			/*显式转换
			 * 
			 * long num;
			int sam = 79;
			num = (int)sam;
			*/

			/*强制转换
			 * 
			 * long num;
			string sam= "78";

			int num =Convert.ToInt32(sam);*/

			/*string num = Console.ReadLine();
			int sam = Convert.ToInt32(num);*/
			//int num = int.Parse("89");
			//int a = 3;
			//int b = 2;
			//float c = (float)a / b;

			//int num = 3;
			//int sam = 4;
			//bool txt = !(num < sam);


			//字符串拼接和内插
			//string name = "源站";
			//string use = "欢迎你";
			//Console.WriteLine(name + "," + use + "!");
			//Console.WriteLine($"{name}," + $"" + Environment.NewLine + "" + $"{use}!");
			//Console.WriteLine(@$"{name},



			//{use}!");
			/*			int num = Convert.ToInt32(Console.ReadLine());


						if (num < 100)
						{
							Console.WriteLine("输入的数小于一百！");

						}
						else
						{
							Console.WriteLine("输入的数字大于一百！");
						}
		*//*				Console.WriteLine();*//*
			重构代码，增加代码的可读性，降低耦和度；
			int num =Convert.ToInt32( Console.ReadLine());
			string sam;
			if (num<=10)
			{
				sam = "你输入的数字小于10";
			}
			else
			{
				sam = "您输入的数字大于10";
			}
			Console.WriteLine(sam);*/


			/*三元表达式、运算符
		   long sam = int.Parse(Console.ReadLine());
			string num = sam >= 10 ? "及格" : "不及格";
			Console.WriteLine(num);*/
			//= Convert.ToString(Console.ReadLine());
			/*	string sam="";
				int num = Console.Read();// Convert.ToInt32(Console.ReadLine());
				if (num > 100 || num < 0) {
					sam = "请输入正确的数字！";
				}
				else if (num < 60)
				{
					sam = "不及格！";
				}
				else if (num >= 60&&num<80)
				{
					sam = "及格";
				}
				else if (num >= 80)
				{
					sam = "优秀";
				}
				Console.WriteLine(sam);*/

			Console.WriteLine("sam");
			Console.Read();
		}
	}
}
