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
			/*	观察一起帮登录页面，用if...else ...完成以下功能。

	用户依次由控制台输入：验证码、用户名和密码：

	如果验证码输入错误，直接输出：“*验证码错误”；
	如果用户名不存在，直接输出：“*用户名不存在”；
	如果用户名或密码错误，输出：“*用户名或密码错误”
	以上全部正确无误，输出：“恭喜！登录成功！”
	PS：验证码 / 用户名 / 密码直接预设在源代码中，输入由Console.ReadLine()完成。*/

			/*	Console.WriteLine("请输入验证码qwer");
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

				}*/

			/*
						作业：

			将源栈同学姓名 / 昵称分别：
			按进栈时间装入一维数组，
			按座位装入二维数组，
			并输出共有多少名同学。*/

			/*			string[] name = { "夏康平 \n昵称\n2020.2",
							"周丁浩\n昵称\n2020.2",
							"姜鹏\n昵称\n2020.2",
							"刘伟\n昵称\n2020.2",
							"胡涛\n昵称\n2020.2" };

						Console.WriteLine(name[0]);
						string[,] seat = new string[2, 3];
						seat[0, 0] = name[0];
						seat[0, 1] = name[1];
						seat[1, 0] = name[2];
						seat[1, 1] = name[3];
						seat[1, 2] = name[4];
						Console.WriteLine(seat[1, 2]);*/
			//输出共有多少名学生
			//Console.WriteLine("共有" + name.Length + "名学生");


			/*作业：

			
			/*分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9*/
			/*for (int i = 1; i < 6; i++)
			{
				Console.WriteLine(i);
			}
			int i = 1;
			while (i<=9)
			{
				
				Console.WriteLine(i);
				i += 2;
			}*/
			/*用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
			String[] name ={ "夏康平 \n昵称\n2020.2",
/*				"周丁浩\n昵称\n2020.2",
				"姜鹏\n昵称\n2020.2",
				"刘伟\n昵称\n2020.2",
				"胡涛\n昵称\n2020.2" };
			
						for (int i = 0; i < name.Length; i++)
						{
							Console.WriteLine(name[i]);
						}*/


			//二维数组
			/*			string[,] seat = new string[2, 3];

						seat[0, 0] = name[0];
						seat[0, 1] = name[1];
						seat[1, 0] = name[2];
						seat[1, 1] = name[3];
						seat[1, 2] = name[4];

						for (int i = 0; i < 2; i++)
						{
							for (int j = 0; j < 3; j++)
							{

								Console.WriteLine(seat[i, j]);
							}
						}*/

			/*找到100以内的所有质数（只能被1和它自己整除的数）*/
			//遍历一到一百之间的数字
			/*			for (int i = 2; i <= 100; i++)
						{
							bool b = true;//定义一个bool值
							for (int j = 2; j < i; j++)
							{
								if (i % j == 0)
								{
									b = false;
									break;
								}//else continue;
							}
							if (b == true)
							{
								Console.WriteLine(i);
							}//else continue;
						}
			*/





			/*生成一个元素（值随机）从小到大排列的数组*/
			/*int[] number = { 1,3,6,2,8,6,9,13,24,5,14,55};
			
			for (int i = 0; i <number.Length; i++)
			{
				for (int j = 0; j < number.Length-1; j++)
				{
					if (number[j] > number[j + 1])
					{
						 int sam = number[j];
						number[j] = number[j + 1];
						number[j + 1] = sam;
						
					}//else continue
					
				}
				
			}
			for (int i = 0; i < number.Length; i++)
			{
				Console.WriteLine(number[i]);
			}*/


			//设立并显示一个多维数组的值，元素值等于下标之和。Console.Write()

			//创建一个二维数组

			/*	int[,] number=new int[2,3];
				number[0, 0] = 0; number[0, 1] = 1; number[0, 2] = 1;
				number[1, 0] = 2; number[1, 1] = 2; number[1, 2] = 3;
				int sam;

				for (int i = 0; i < 2; i++)
				{
					for (int j = 0; j < 3; j++)
					{
						sam = number[i, j];
						Console.Write(sam);
						Console.Write("\t");
					}
					Console.Write("\n");
				}*/

			//二分查找
			/*int[] sam =new int[1000];
			for (int j = 0; j < sam.Length; j++)
			{
				sam[j] = j;
			}
			int num = new Random().Next(1, 1000);
			int left = 0;
			int right = sam.Length;
			int mid = (left + sam.Length) / 2;
			int i = 0;
			while ( i <sam.Length-1)
			{
				i++;
				mid = (left + right) / 2;
				if (num>mid)
				{
					left = mid;
				}
				else if (num<mid)
				{
					right = mid;
				}
				//else
				if(num==mid)
				{
					Console.WriteLine($"数字是{num}查找用了{i+1}次");
					break;
				}//else continue
			}*/



			/*			Console.WriteLine(Math.Round(19.55,1,MidpointRounding.AwayFromZero));
						Console.WriteLine(new Random().Next(100 ,1000));
						int sam = new Random().Next(100, 1000);*/
			/*			Console.WriteLine(sam);*/

			//调用函数，用户猜数字
			/*int sam = new Random().Next(1, 1000);
			Console.WriteLine("请输入一个一到一千之间的整数");
			//Console.WriteLine(GuessMe(sam,0,15));

				GuessMe(sam, 14);*/

			/*利用ref调用Swap()方法交换两个同学的床位号*/
			/*int liu = 2,zhang= 3;
			berth(ref liu, ref zhang );
			Console.WriteLine(liu);*/


			//调用一个方法显示登录信息，比显示登录失败的原因
			/*Console.WriteLine("请输入用户名");
			string name = Console.ReadLine();
			Console.WriteLine("请输入密码");
			int psw = Convert.ToInt32(Console.ReadLine());
			string msg;
			bool b = logOn(name, psw, out msg);
			Console.WriteLine(msg + b);*/

		/*	int[] tttt = { 1, 5, 8, 654, 898, 58, 456, 456, 6, 565, 4875, 965874, 554, 77, 33, 888, 789 };
			QuickSort(tttt, tttt[0], tttt.Length);
			for (int i = 0; i <tttt.Length-1; i++)
			{
				Console.WriteLine(tttt[i]);
			}*/
			

		


		/*	计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
	完成“猜数字”游戏，方法名GuessMe()：*/
		/*int[] sam = { 77, 88, 99, 78, 79, 80 };
		float num=0;
		GetAverage(sam, num);*/

		/*	计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
		//完成“猜数字”游戏，方法名GuessMe()：*/

		/// <summary>
		/// 源栈同学成绩
		/// </summary>
		/// <param name="a">一个包含源栈同学成绩的数组</param>
		/// <param name="b">用来装总成绩</param>
		/// <returns></returns>
		/*static int GetAverage(int[] a, float b)
		{

			for (int i = 0; i < a.Length - 1; i++)
			{
				b = a[i] + b;

			}

			Console.WriteLine(Math.Round(b / a.Length, 2));
			return -1;
		}*/


		/*随机生成一个大于0小于1000的整数
		用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
		没猜中可以继续猜，但最多不能超过10次
			如果5次之内猜中，输出：你真牛逼！
			如果8次之内猜中，输出：不错嘛！
			10次还没猜中，输出：(～￣(OO)￣)ブ*/
		/// <summary>
		/// 用户可以自定义查找的次数
		/// </summary>
		/// <param name="sam">取值范围</param>
		/// <param name="a">定义输入次数</param>
		/// <returns>返回</returns>
		/*static int GuessMe(int sam, int a)
		{
			for (int i = 0; i < a; i++)
			{

				int num =int.Parse(Console.ReadLine());
				if (num == sam && i < a)
				{
					if (i < a - 1 && i > 5)
					{
						Console.WriteLine("不错嘛！");

						if (i <= 5)
						{
							Console.WriteLine("你真牛逼！");
							break;
						}
						break;
					}
					//else 
				}
				else if (i == a - 1)
				{
					Console.WriteLine("(～￣(OO)￣)ブ");
				}
				else if (num >= sam)
				{
					Console.WriteLine($"大了,还剩{a - 1 - i}次");
				}
				else if (num <= sam)
				{
					Console.WriteLine($"小了,还剩{a - 1 - i}次");
				}
			}
			return -1;
		}*/
		//平均数
		/*int[] sam = { 77, 88, 99, 78, 79, 80 };
		int num = 0;
		for (int i = 0; i < sam.Length - 1; i++)
		{
			num = sam[i] + num;
		}
		Console.WriteLine(num / sam.Length);*/

		//递归
		/*static void getFibonacci(int a,int b) 
		{
			int sam = a + b;
			Console.WriteLine(b);
			getFibonacci(b, sam);

		}*/
		///
		//快速排序
		/*static void QuickSort(int[] nums,int left,int right)
			{
				if (left < right)
				{
					int i = left;
					int j = right - 1;
					int middle = nums[(left + right) / 2];
					while (true)
					{
						while (i < right && nums[i] < middle)
						{
							i++;
						}
						while (j > 0 && nums[j] > middle)
						{
							j--;
						}
						if (i==j)
						{
							break;
						}
						nums[i] = nums[i] + nums[j];
						nums[j] = nums[i] - nums[j];
						nums[i] = nums[i] - nums[j];
					}

				}
			}*/



		}

/*
		static void quickSort(int[] array)
		{
			int left = array[0];
			int right = array.Length - 1;
			while (array[right] > left)
			{
				right--;
				while (right <right-1||right==array.Length/2)
				{
					swep(left, array[right], array[left]);
				}
				
			}
		}

		private static void swep(int left, int right, int typm)
		{
			typm = right - 1;
			right= left-1;
			left = right;

		}*/



		/*利用ref调用Swap()方法交换两个同学的床位号*/

		/*static void berth(ref int a, ref int b)
		{
			int tepm = 0;
			swap(ref a , ref b,ref tepm);
		}

		private static void swap(ref int a, ref int b, ref int tepm)
		{
			tepm = a;
			a = b;
			b = tepm;
		}*/


		/*将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
true/false，表示登陆是否成功
string，表示登陆失败的原因*/
		/// <summary>
		/// 判断是否登录成功
		/// </summary>
		/// <param name="name">用户名</param>
		/// <param name="psw">密码</param>
		/// <param name="msg">返回的信息</param>
		/// <returns></returns>
		/*static bool logOn(string name, int psw,out string msg)
		{
			if (name == "qwer" && psw == 123456)
			{
				msg = "登录成功";
				return true;

			}
			else if (name=="qwer")
			{
				msg = "密码错误";
				return false;
			}
			else if (psw==123456)
			{
				msg = "用户名错误";
				return false;
			}
			else 
			{
				msg = "未知错误";
				return false;
			}

		}*/
	}
}
