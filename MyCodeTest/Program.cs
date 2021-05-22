using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeTest
{
	class Program
	{
		static Func<int> AiCaculate()
		{
			int a = 100, b = 50;
			return () => a * b;
		}
		static void Main(string[] args)
		{
		
			//List<Student> students = new List<Student>(); 
			//{
			//new Student{ age=19},
			//new Student{ age=18},
			//new Student{ age=20},
			//new Student{ age=30 }
			//};
			//students.MyAny(s => s.age >30);
			//AiCaculate();
			//Func<int> func = AiCaculate();
			//Console.WriteLine(func());
			//int re = func();
			//Console.WriteLine(re);

			#region 委托
			//AiCaculate(16, 18, (x, y) => { Console.WriteLine(x%y); });

			//AiCaculate(2, 2, delegate (int a)
			//  {
			//	  int b = 10;
			//	  Console.WriteLine($"{a}*{b}={a * b}");
			//	  return a * b;
			//  });
			//AiCaculate(2, 2, (a) =>
			//  {
			//	  int b = 10;
			//	  Console.WriteLine($"{a}*{b}={a * b}");
			//	  return a * b;
			//  });
			//Func<int, int> ss = a => a * a;//lambda表达式
			//Func<int, int> sss = (a) => a * a;//lambda表达式
			//Opt opt = null;
			//opt = AiCaculate;
			//opt(1, 2);
			#endregion


		}

	}
	public class Student
	{ 
	public int age { get; set; }
	}
	public static class MyClass
	{
		//public static bool MyAny(this List<Student> students,Func<Student,bool> func)
		//{
		//	foreach (var item in students)
		//	{
		//		if (func(item))
		//		{
		//			return true;
		//		}
		//	}
		//	return false;
		//}
	}
}
