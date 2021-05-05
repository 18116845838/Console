using System;
using SelfStudy;

namespace Test
{


	class Program
	{
		static void Main(string[] args)
		{
			User niu = new Student();
			//is的用法
			if (niu is Student)
			{
				((Student)niu).age = 20;
			}
			//as的用法
			Student converted =niu as Student;
			if (converted!=null)
			{
				Console.WriteLine(converted.age);
			}
			
			Console.WriteLine(((Student)niu).age);


			//new Student(21, 22);
			//Console.WriteLine(new Student(21, 22));

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
			//		作业

			//观察一起帮登录页面，用if...else...完成以下功能。

			//用户依次由控制台输入：验证码、用户名和密码：

			//    如果验证码输入错误，直接输出：“* 验证码错误”；
			//    如果用户名不存在，直接输出：“* 用户名不存在”；
			//    如果用户名或密码错误，输出：“* 用户名或密码错误”
			//    以上全部正确无误，输出：“恭喜！登录成功！”

			//PS：验证码/用户名/密码直接预设在源代码中，输入由Console.ReadLine() 完成。
			//Student zs = new Student("张三");*/
			//Student.enroll(new Student("zzss"));
			////Student ls = new Student("李四");
			//Student.enroll(new Student("llss"));


		}
	}
}
