using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
						作业：

			将源栈同学姓名 / 昵称分别：
			按进栈时间装入一维数组，
			按座位装入二维数组，
			并输出共有多少名同学。*/

			string[] name = { "夏康平 \n昵称\n2020.2",
				"陈国栋\n昵称\n2020.2",
				"姜鹏\n昵称\n2020.2", 
				"刘伟\n昵称\n2020.2", 
				"胡涛\n昵称\n2020.2" };
			
			Console.WriteLine(name[0]);
			string[,] seat = new string [2,3];
			seat[0, 0] = name[0];
			seat[0, 1] = name[1];
			seat[1, 0] = name[2];
			seat[1, 1] = name[3];
			seat[1,2] = name[4];
			Console.WriteLine(seat[1,2]);
			//输出共有多少名学生
			Console.WriteLine("共有"+name.Length+"名学生");
		
		}
	}
}
