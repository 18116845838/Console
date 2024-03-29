﻿using System;

namespace ConsoleApp1
{
	[AttributeUsage(AttributeTargets.Method)]
	public class HelpMoneyChangedAttribute:Attribute
	{       //	自定义一个特性HelpMoneyChanged（帮帮币变化）：
			//   该特性只能用于方法
			//有一个构造函数，可以接受一个int类型的参数amount，表示帮帮币变化的数量
			//有一个string类型的Message属性，记录帮帮币变化的原因
			//将HelpMoneyChanged应用于Publish()方法

			//用反射获取Publish()上的特性实例，输出其中包含的信息
			//public HelpMoneyChangedAttribute(int amount)
			//{

		//}
		public HelpMoneyChangedAttribute(int amount)
		{

		}
		public string  Message
		{
			get;
			set;
		}
		#region 获取特性信息方法
		public static void FeatureInformation()
		{
			Attribute attribute = Attribute.GetCustomAttribute(
				typeof(Content).GetMethod("Publish"),
				typeof(HelpMoneyChangedAttribute)
				);
			Console.WriteLine(((HelpMoneyChangedAttribute)attribute).Message);
		}
		#endregion

	}
}
