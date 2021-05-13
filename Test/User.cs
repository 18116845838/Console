using System;
using System.Collections.Generic;
using System.Text;

namespace SelfStudy
{

	//internal class OnlineAttribute : Attribute
	//{
	//	public int Vertual { get; set; } 
	//}
	//[Online (Vertual=3)]
	class User
	{


		private DateTime shijian=DateTime.Now;
		public void Greet(string name)
		{
			Console.WriteLine($"你好啊我叫{name}");	
		}
		//private static User _name;
		///*private*/public User()
		//{

		//}
		//public static  User sam()
		//{
		//	if (_name==null)
		//	{
		//		_name = new User();

		//	}
		//	return _name;
		//}

		//public User()
		//{
		//	Console.WriteLine();
		//}
		////受保护的
		//protected int sam;
		
		//public User(string a,int b,int c)
		//{ 
		
		//}
		//private string _name;
		//public string Name { get; set; }
		//private int _nam;
		//public int Nam { get; set; }
		//public void users()
		//{ 
		
		//}

	}
	struct Bed
	{
		public string _name;
		public const int _sam=0;
		
		public Bed(string  num)
		{
			_name = num;
		}
	
	}

}
