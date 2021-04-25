using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*作业：
			让电脑计算并输出：99+97+95+93+...+1的值*/

			int num=0;
			for (int i = 99; i > 0; i-=2)
			{
				num+=i;
			}
			Console.WriteLine(num);





			/*将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分*/
			double[] grade = { 77.7, 79.8, 87.8, 99.5, 79.6,99.9 };
			double max = grade[0];
			for (int i = 1; i < grade.Length; i++)
			{
				if (max<grade[i])
				{
					max = grade[i];
				}
			}
			Console.WriteLine(max);
			//最小值
			
			double min =grade[0];
			for (int i = 1; i < grade.Length; i++)
			{
				if (min > grade[i])
				{
					min = grade[i];
				}
			}
			Console.WriteLine(min);


		}
	}
}
