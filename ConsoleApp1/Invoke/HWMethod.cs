using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ConsoleApp1.Invoke
{
	class HWMethod
	{
		# region 在Content之外封装一个方法，可以修改Content的CreateTime和PublishTime 
		//之前的Content类，其中的CreateTime（创建时间）和PublishTime（发布时间）都是只读的属性，
		//想一想他们应该在哪里赋值比较好，并完成相应代码
		//反射_createTime字段
		public static void AlterCreationtime(Content content, DateTime datetime)
		{

			typeof(Content).GetProperty(
			"CreateTime", BindingFlags.Public |
			BindingFlags.Instance).SetValue(content, datetime);
			Console.WriteLine(datetime);

		}
		public static void AlterpubllishTime(Content content, DateTime dateTime)
		{
			typeof(Content).GetProperty(
			"PublishTime", BindingFlags.Public |
			BindingFlags.Instance).SetValue(content, dateTime);
			//Console.WriteLine(content);
		}
		#endregion

	}
}
