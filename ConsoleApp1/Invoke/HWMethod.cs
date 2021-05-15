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
	}
}
