using System;
using System.Collections.Generic;
using System.Text;

namespace SelfStudy
{
	class Student
	{
		//访问修饰符
		//private 
		//public 
		//internal

		//析构函数
		~Student()
		{
			Console.WriteLine("垃圾已回收!");
		}

		static string at = "源栈";
		private string _name;

		public static Student[] students = new Student[20];
		public Student(string name)
		{
			_name = name;
		}
		internal void learn(int score)
		{ 
		
		}
		public static int enroll(Student student)
		{
			for (int i = 0; i < students.Length; i++)
			{
				if (students[i]==null)
				{
					students[i] = student;
					Console.WriteLine(students[i]);
				}//else continue 
				return i;
			}
			return -1;
		}
	}
}
