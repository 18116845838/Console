using System;
using System.Collections.Generic;
using System.Text;

namespace SelfStudy
{
	class Student : User
	{

	  public int  age;

		public static bool operator <(Student a, Student b)
		{
			return a.age > b.age;
		}
		public static bool operator >(Student a, Student b)
		{
			return a.age < b.age;
		}
		public static explicit operator YP(Student student)
		{
			return new YP();
		} 
		public static implicit operator Student(YP yP)
		{
			return new Student();
		}





		//public int age;
		//public Student():base()
		//{


		//}
		//User ll = new Student();
		////Student kk = new User("",2,5);
		//User lv = new User();



		//访问修饰符
		//private 
		//public 
		//internal

		//析构函数
		//~Student()
		//{
		//	Console.WriteLine("垃圾已回收!");
		//}

		//static string at = "源栈";
		//private string _name;

		//public static Student[] students = new Student[20];
		//public Student(string name)
		//{
		//	_name = name;
		//}
		//internal void learn(int score)
		//{ 

		//}
		//public static int enroll(Student student)
		//{
		//	for (int i = 0; i < students.Length; i++)
		//	{
		//		if (students[i]==null)
		//		{
		//			students[i] = student;
		//			Console.WriteLine(students[i]);
		//		}//else continue 
		//		return i;
		//	}
		//	return -1;
		//}
	}

	public interface I1
	{
		void m1();

	}
	public interface I2
	{
		void m1();

	}
	public interface I3
	{
		void m1();

	}

	public interface I4 : I1, I2, I3
	{

	}


	class Max : I1, I2, I3// I4
	{
		void I1.m1()
		{
			Console.WriteLine("这是接口一的方法");
		}

		void I3.m1()
		{
			Console.WriteLine("这是接口二的方法");
		}

		void I2.m1()
		{
			Console.WriteLine("这是接口三的方法");
		}
	}
	//internal
	//interface

	//protected
	//protected
	//protected
	//protected
	//protected
	//protected
	//protected
	//virtual
	//virtual
	//virtual
	//virtual
	//virtual
	//virtual
	//virtual 
	//virtual
	//override
	//override
	//override
	//virtual
	//virtual
	//virtual
	//virtual
	//virtual
	//virtual




}
