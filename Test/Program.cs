﻿using System;

namespace Test
{
	

	class Program
	{
		

		/// <summary>
		/// 
		/// </summary>
		/// <param name="scores"></param>
		/// <returns></returns>
		/*	static string min(string[] scores)//函数的名称，类型和元素
			{
				//函数体
				for (int i = 0; i < scores.Length; i++)
				{

					if (scores[i]== "")
					{
						Console.WriteLine("zhaodaole");
						return "";
					}//else continue 

				}
				return "";
			}
			static void max()
			{
				Console.WriteLine("函数使用");
				return;
			}*/
		/*	static float GetAverage(float a, float b)
			{
				return 1.2;
			}*/
		/*作业

观察一起帮登录页面，用if...else...完成以下功能。

用户依次由控制台输入：验证码、用户名和密码：

    如果验证码输入错误，直接输出：“* 验证码错误”；
    如果用户名不存在，直接输出：“* 用户名不存在”；
    如果用户名或密码错误，输出：“* 用户名或密码错误”
    以上全部正确无误，输出：“恭喜！登录成功！”

PS：验证码/用户名/密码直接预设在源代码中，输入由Console.ReadLine() 完成。*/
		static string GetAverage(string num, string sam,string name)
		{
			Console.WriteLine("请输入验证码qwer");
			num = Console.ReadLine();
			if (num!= "qwer")
			{
				Console.WriteLine("验证码输入错误！");
				
			}
			else 
			{
				Console.WriteLine("请输入用户名：羊生");
				sam = Console.ReadLine();
				if (sam!="羊生")
				{
					Console.WriteLine("输入的用户名错误");
					name = Console.ReadLine();
				}
				else
				{
					Console.WriteLine("请输入密码123456");
					if (name!= "123456")
					{
						Console.WriteLine("输入的密码错误！");
					}
					else
					{
						Console.WriteLine("恭喜您登录成功！");
					}
				}
			}

			return "";
		}

	}
}
