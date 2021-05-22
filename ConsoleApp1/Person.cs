using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public delegate int ProvideWater(Person person);
	public class Person
	{
		//声明一个委托：打水（ProvideWater），可以接受一个Person类的参数，返回值为int类型
		//使用：
		//	方法
		//	匿名方法
		//	lambda表达式
		//给上述委托赋值，并运行该委托
		public int Age { get; set; }
		public int RtMax(Person person)
		{
			return 6;
		}
		public static void Execut()
		{
			ProvideWater provideWater = new ProvideWater(new Person().RtMax);
			provideWater(new Person());
			provideWater += delegate (Person person) { return 5; };
			provideWater += (Person) => 3;
			

		}
		#region //声明一个方法GetWater()，该方法接受ProvideWater作为参数，并能将ProvideWater的返回值输出
		public static void GetWater(Person person, ProvideWater provideWater)
		{
			Console.WriteLine(provideWater(person));
		}
		#endregion

	}
}
