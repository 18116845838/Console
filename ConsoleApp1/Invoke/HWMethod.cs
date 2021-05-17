using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ConsoleApp1.Invoke
{
	public class HWMethod
	{
		#region 在Content之外封装一个方法，可以修改Content的CreateTime和PublishTime 
		//之前的Content类，其中的CreateTime（创建时间）和PublishTime（发布时间）都是只读的属性，
		//想一想他们应该在哪里赋值比较好，并完成相应代码
		//反射_createTime字段
		//public static void AlterCreationtime(Content content, DateTime datetime)
		//{

		//	typeof(Content).GetProperty(
		//	"CreateTime", BindingFlags.Public |
		//	BindingFlags.Instance).SetValue(content, datetime);
		//	Console.WriteLine(datetime);

		//}
		//public static void AlterpubllishTime(Content content, DateTime dateTime)
		//{
		//	typeof(Content).GetProperty(
		//	"PublishTime", BindingFlags.Public |
		//	BindingFlags.Instance).SetValue(content, dateTime);
		//	//Console.WriteLine(content);
		//}
		#endregion
		#region 面向对象单元测试数组最大值封装为方法
		public static int Max(int[] number)
		{
			int max = 0;
			for (int i = 0; i < number.Length; i++)
			{
				if (max < number[i])
				{
					max = number[i];
				}
				//else
			}
			return max;
		}
		#endregion
		#region 测试一百以内的质数
		public static int PrimeNumber()
		{
			/*找到100以内的所有质数（只能被1和它自己整除的数）*/
			//遍历一到一百之间的数字
			int number = 0;
			for (int i = 2; i <= 100; i++)
			{

				bool isPrme = true;//定义一个bool值
				for (int j = 2; j < i; j++)
				{
					if (i % j == 0)
					{
						isPrme = false;
						break;
					}//else continue;
				}
				if (isPrme)
				{
					number++;
					Console.WriteLine(i);
				}//else continue;
			}
			return number;
		}
		public static bool ISPrimeNumber(int num)
		{
			//查看是不是质数

			bool isPrme = true;//定义一个bool值
			for (int j = 2; j < num; j++)
			{
				if (num % j == 0)
				{
					isPrme = false;
					break;
				}//else continue;
				else
				{
					return true;
				}//else continue;
			}

			return false;
		}
		#endregion
		#region 单元测试完成“猜数字”游戏，方法名GuessMe()：


		//随机生成一个大于0小于1000的整数
		//用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
		//没猜中可以继续猜，但最多不能超过10次
		//	如果5次之内猜中，输出：你真牛逼！
		//	如果8次之内猜中，输出：不错嘛！
		//	10次还没猜中，输出：(～￣(OO)￣)ブ
		/// <summary>
		/// 用户可以自定义查找的次数
		/// </summary>
		/// <param name="sam">取值范围</param>
		/// <param name="a">定义输入次数</param>
		/// <returns>返回</returns>
		public static int GuessMe(int sam)
		{
			for (int i = 1; i <= 10; i++)
			{
				int num = int.Parse(Console.ReadLine());
				if (num == sam && i < 10)
				{
					if (i < 10 - 1 && i > 5)
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
				else if (i == 10 - 1)
				{
					Console.WriteLine("(～￣(OO)￣)ブ");
				}
				else if (num >= sam)
				{
					Console.WriteLine($"大了,还剩{10 - i}次");
				}
				else if (num <= sam)
				{
					Console.WriteLine($"小了,还剩{10 - i}次");
				}
			}
			return -1;
		}
		#endregion
		#region  单元测试实现二分查找，方法名BinarySeek（int【】 numbers，int target）：
		//传入一个有序（从大到小/从小到大）数组和数组中要查找的元素
		//如果找到，返回该元素所在的下标，否则，返回-1*/
		/// <summary>
		/// 实现二分查找，方法名BinarySeek
		/// </summary>
		/// <param name="numbers">传入一个有序的数组</param>
		/// <param name="target">要查找的元素</param>
		/// <returns>返回-1</returns>
		public static int BinarySeek(int[] numbers, int target)
		{

			int left = 0;
			int right = numbers.Length - 1;
			int middle;
			while (left <= right)
			{
				middle = (left + right) / 2;
				if (numbers[middle] > target)
				{
					right = middle - 1;
				}
				else if (numbers[middle] < target)
				{
					left = middle + 1;
				}
				else
				{
					return middle;  //返回元素所在下标
				}
				//else continue
			}
			return -1;
		}
		#endregion
		#region 通过控制台读取用户输入，比如：3月，12周，100天，利用之前作业的GetDate()方法，输出指定时间段后的日期
		public static DateTime GetDate(DateTime dateTime, string input)
		{
			string num = string.Empty;
			if (input.Contains("天"))
			{
				dateTime = dateTime.AddDays(int.Parse(input.Remove(input.IndexOf("天"))));
			}
			else if (input.Contains("周"))
			{
				dateTime = dateTime.AddDays(int.Parse(input.Remove(input.IndexOf("周"))) * 7);
			}
			else if (input.Contains("月"))
			{
				dateTime = dateTime.AddMonths(int.Parse(input.Remove(input.IndexOf("月"))));
			}
			else
			{
				Console.WriteLine("请输入正确的日期");
			}


			return dateTime;
		}
		#endregion
		#region 实现GetCount(string container, string target)方法，可以统计出container中有多少个target 
		public static int GetCount(string container, string target)
		{
			int i = 0;
			while (container.Contains(target))
			{
				container = container.Remove(0, container.IndexOf(target) + 1);
				i++;
			}
			return i;
		}
		#endregion
		#region 不使用string自带的Join()方法，定义一个mimicJoin()方法，能将若干字符串用指定的分隔符连接起来，
		//比如：mimicJoin("-","a","b","c","d")，其运行结果为：a-b-c-d 
		public static string MimicJoin(char addChar, string[] value)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < value.Length; i++)
			{
				sb.Append(value[i]);
				if (i!=value.Length-1)
				{
					sb.Append(addChar);
				}
			}
			return sb.ToString();
		}
		#endregion




	}
}
