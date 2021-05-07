using System;
using SelfStudy;

namespace Test
{


	class Program
	{
		static void Main(string[] args)
		{

			//调用抽象类
			Animal mm = new Dog();
			Animal dd = new Cat();
			dd.Back();
			
			mm.Back();
			Console.WriteLine();

			//抽象类 狗汪汪的叫，猫咪喵喵的叫


			//调用虚方法
			//student r1 = new student("井上");
			//student r2 = new student("水下");
			//chanese c1 = new chanese("黄晓明");
			//chanese c2 = new chanese("潘子");
			//mei m1 = new mei("ttt");
			//mei m2 = new mei("ccc");
			//MyClass[] arrays = { r1, r2, c1, c2, m1, m2 };
			//for (int i = 0; i <arrays.Length; i++)
			//{
			//	//if (arrays[i] is student)
			//	//{
			//	//	((student)arrays[i]).seyhallo();
			//	//}
			//	//else if (arrays[i] is chanese)
			//	//{
			//	//	((chanese)arrays[i]).seyhallo();

			//	//}
			//	//else
			//	//{
			//	//	((mei)arrays[i]).seyhallo();
			//	//}
			//	arrays[i].seyhallo();

			//}

			//练习虚方法
			//student ll = new student("阿飞");
			//student kk = new student("上中");
			//chanese ww = new chanese("盘子");

			//chanese qq = new chanese("打不溜");
			//mei ee = new mei("meimingzi");
			//mei bb = new mei("zhib");
			//niu cc = new niu("牛镇人");
			//niu vv = new niu("taintainn");
			//MyClass[] arrays = { ll, kk, ww, qq, ee, bb, cc, vv };

			//for (int i = 0; i < arrays.Length; i++)
			//{
			//	arrays[i].seyhallo();
			//}










			//Student ll = new Student();


			//User lk = new Student();
			//if (lk is Student)
			//{
			//	Student lo = new Student();
			//}
			////else

			//Student li =lk as Student;




			//User niu = new Student();
			////is的用法
			//if (niu is Student)
			//{
			//	((Student)niu).age = 20;
			//}
			////as的用法
			//Student converted =niu as Student;
			//if (converted!=null)
			//{
			//	Console.WriteLine(converted.age);
			//}

			//Console.WriteLine(((Student)niu).age);


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

	class  MyClass
	{
		private string _name;
		public string Name { get; set; }

		public MyClass(string name)
		{
			this.Name = name;
		}
		public virtual void seyhallo()
		{
			Console.WriteLine("我是人类");
		}
	}
	class student : MyClass
	{
		public student(string name) : base(name)
		{
		}

		public override void seyhallo()
		{
			Console.WriteLine($"我是日本人,我叫{Name}");
		}
	}
	class chanese : MyClass
	{
		public chanese(string name) : base(name)
		{

		}
		public override void seyhallo()
		{
			Console.WriteLine($"我是中国人，我叫{Name}");
		}

	}
	class mei : MyClass
	{
		public mei(string name) : base(name)
		{

		}
		public override void seyhallo()
		{
			Console.WriteLine($"我是美国人,我叫{Name}");
		}

	}
	class niu:MyClass
	{
		public niu(string name):base(name)
		{

		}
		//public override void seyhallo()
		//{
		//	Console.WriteLine($"我是牛国人，我叫{Name}");
		//}

	}

	//抽象类
	 abstract class Animal
	{
		public abstract void Back();
	}

	class Dog:Animal
	{
		public override void Back() {
			Console.WriteLine("狗子汪汪的叫");
		}

	}
	class Cat:Animal
	{

		public override  void Back() {
			Console.WriteLine("喵咪喵喵的叫");
		}
	}
}
	
