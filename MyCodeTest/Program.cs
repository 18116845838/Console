using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeTest
{
	class Program
	{
		public static void AiCaculate(object sender, EventArgs eventArgs)
		{
			Console.WriteLine("shijian");

		}
		static void Main(string[] args)
		{
			throw new Exception
			#region 拉姆达表达式？
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
			#endregion
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
			#region 事件
			//	MyClass myClass = new MyClass();
			//	myClass.OnClick += AiCaculate;
			//	myClass.OnClick += MyClass_OnClick;

			//}

			//private static void MyClass_OnClick(object sender, EventArgs e)
			//{
			//	throw new NotImplementedException();
			//}
			#endregion
			#region 变体，协变逆变
			//Func<Student> func = null;
			//Myfunc<MyClass, myckass2> myfunc = null;
			//Myfunc<myckass2, MyClass> myfunc1 = null;
			//myfunc = myfunc1;
			//myfunc1 = myfunc;

			#endregion
			#region linq语句查询
			//		Teacher fg = new Teacher { Age=19, Name = "大飞哥" };
			//		Teacher fish = new Teacher {Age=23, Name = "小鱼" };
			//		Teacher dfg = new Teacher {  Age = 39, Name = "大飞哥" };
			//		IEnumerable<Teacher> teachers = new List<Teacher> { fg, fish, dfg };

			//		Major csharp = new Major { Name = "C#", Age = 19, TeacherName= "大飞哥" };
			//		Major SQL = new Major { Name = "SQL", Age = 19, TeacherName = "大飞哥" };
			//		Major Javascript = new Major { Name = "Javascript", Age = 39, TeacherName = "大飞哥" };
			//		Major UI = new Major { Name = "UI", Age = 23, TeacherName = "小鱼" };
			//		IEnumerable<Major> majors = new List<Major> { csharp, SQL, Javascript, UI };

			//		IList<Student> students = new List<Student>
			//{
			//	new Student{Score = 98, Name = "屿", Majors=new List<Major>{csharp,SQL } },
			//	new Student{Score = 86, Name = "行人", Majors=new List<Major>{Javascript, csharp, SQL} },
			//	new Student{Score = 78, Name = "王平", Majors=new List<Major>{csharp}},
			//	new Student{Score = 89, Name = "王枫", Majors=new List<Major>{Javascript, csharp, SQL,UI}},
			//	new Student{Score = 98, Name = "蒋宜蒙", Majors=new List<Major>{Javascript, csharp}},
			//};

			#endregion

			//var a = from s in students
			//		orderby s.Score ascending
			//		select s;
			//foreach (var item in a)
			//{
			//	Console.WriteLine($"{item.Name}{item.age}{item.Score}");
			//}
			//IEnumerable<IGrouping<Teacher,Major>> b = from s in majors
			//		group s by s.Teacher;
			//foreach (IGrouping<Teacher,Major> item in b)
			//{
			//	Console.WriteLine(item.Key.Name);
			//	foreach (Major major in item)
			//	{
			//		Console.WriteLine(major.Name);
			//	}
			//	Console.WriteLine(item.Average(m=>m.));
			//}
			//var t = from m in majors
			//		group m by m.Teacher into mg
			//		select new { mg.Key, Count = mg.Count() };
			//foreach (var item in t)
			//{
			//	Console.WriteLine(item.Key.Name+item.Count);
			//}

			//var t = from m in majors
			//		//where m.Teacher.Name == "小鱼";条件表达式，筛选
			//		group m by m.TeacherId into mg

			//		select new { mg.Key, value = mg.Count() }
			//	  ;
			//var ss = t.ToDictionary(s => s.Key, s => s.value);
			//var r = t.ToList();
			//foreach (var b in ss)
			//{
			//	Console.WriteLine(b.Key + "" + b.Value);
			//}
			//var w = from m in majors
			//		join t in teachers
			//		on m.TeacherId equals t.Id
			//		select new { t.Id, teachername = t.Name, majorsname = m.Name };
			//var f = from t in teachers//join链接
			//		join m in majors
			//		on t.Id equals m.Age
			//		into sd
			//		from cf in sd.DefaultIfEmpty()
			//		select new { t = t.Name, m = cf?.Name ?? "" };
			//var g = from t in teachers一行一行的分类输出
			//		join m in majors
			//		on new { t.Name, t.Age } equals new { Name = m.TeacherName, m.Age }
			//		select new { t = t.Name, m = m.Name, t.Age };
			//var g = from s in students//一列一列的输出
			//		let mq = s.Majors
			//		from sm in mq
			//		select new { s = s.Name, t = sm.Name };
			//var gg = from s in students
			//		 where s.Name.StartsWith("王")
			//		 select s;
			//if (true)
			//{
			//	gg = from g in gg.ToList()
			//		 where g.Score > 80
			//		 select g;
			//}
			//students.Add(new Student() { Score = 98, Name = "王宜蒙", Majors = new List<Major> { Javascript, csharp } });
			//if (true)
			//{
			//	gg = from g in gg
			//		 where g.Majors.Count() > 3
			//		 select g;
			//}
			//foreach (var item in gg)
			//{
			//	Console.WriteLine(item.Name + item.Score + item.Majors.Count());
			//}
			//Console.ReadKey();
		}
		//public static IEnumerable<T> Mm<T>(IEnumerable<T> ts,Func<T, bool> func)
		//{
		//	IList<T> students = new List<T>();
		//	foreach (var item in ts)
		//	{
		//		if (func(item))
		//		{
		//			yield return item;
		//		}
		//	}
		//}
		#region 比较的一些方法 
		public static void ff<T>(T a, T b, Func<T, T, bool> func)//来利用func进行比较
		{
			if (func(a, b))
			{

			}
		}
		public static void dd<T>(T a, T b) where T : IComparable//来继承Icomparable接口进行比较
		{
			if (a.CompareTo(b) < 0)//可以使用ConmpareTo方法
			{

			}
		}
		public static void gg<T>(T a, T b, Mycomoerble<T> mycomoerble)//自定义实现接口进行比较
		{
			if (mycomoerble.Comperble(a, b))
			{

			}
		}
		public interface Mycomoerble<T>//自定义接口
		{
			bool Comperble(T a, T b);
		}
		#endregion

		public delegate T Myfunc<in T1, out T>(T1 t1);
		public class Student
		{
			public int Score { get; set; }
			public string Name { get; set; }
			public IEnumerable<Major> Majors { get; set; }
			public int age { get; set; }
		}
		public class Teacher
		{
			public int Id { get; set; }
			public string Name { get; set; }
			public int Age { get; set; }
			public event EventHandler OnClick;
			//public void Click()
			//{
			//	OnClick?.Invoke(this, null);
			//}
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
		public class Major
		{
			public string Name { get; set; }
			public int Age { get; set; }
			public string TeacherName { get; internal set; }
		}
	}
}