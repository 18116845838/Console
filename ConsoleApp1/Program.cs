using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{

			/*	观察一起帮登录页面，用if...else ...完成以下功能。

	用户依次由控制台输入：验证码、用户名和密码：

	如果验证码输入错误，直接输出：“*验证码错误”；
	如果用户名不存在，直接输出：“*用户名不存在”；
	如果用户名或密码错误，输出：“*用户名或密码错误”
	以上全部正确无误，输出：“恭喜！登录成功！”
	PS：验证码 / 用户名 / 密码直接预设在源代码中，输入由Console.ReadLine()完成。*/

			Console.WriteLine("请输入验证码qwer");
			string num = Convert.ToString(Console.ReadLine());
			if (num != "qwer")
			{
				Console.WriteLine("*验证码错误");
			}
			else
			{
				Console.WriteLine("请输入用户名羊生");
				string sam = Convert.ToString(Console.ReadLine());
				if (sam != "羊生")
				{
					Console.WriteLine("用户名不存在");

				}
				else
				{

					Console.WriteLine("请输入密码123456");
					string number = Convert.ToString(Console.ReadLine());
					if (number != "123456")
					{
						Console.WriteLine("用户名或者密码错误");
					}
					else
					{
						Console.WriteLine("恭喜你登录成功！");
					}
				}

			}
		}
	}
}
