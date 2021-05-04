using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class Problem
	{
		/*求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、
		发布时间（PublishDateTime）和作者（Author），和方法Publish()*/
		//一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
		//
		//求助板块索引器

		

		private string[] help;

		public string this[int index]
		{
			get { return help[index - 1]; }
			set { help[index - 1] = value; }
		}
		/// <summary>
		/// 设置索引器长度
		/// </summary>
		/// <param name="lenth">索引器的长度</param>
		public Problem(int lenth)
		{
			help = new string[lenth];
		}
		//	设计一种方式，保证：

		//   每一个Problem对象一定有Body赋值
		public Problem(string body)
		{
			_body = body;
		}
		//每一个User对象一定有Name和Password赋值

		///// // ////////
		private string _title;
		public string Title { get; set; }
		private string _body;
		public string Body { get; set; }

		private int _reward;
		public int Reward
		{
			get
			{
				if (Reward < 0)
				{
					Console.WriteLine("悬赏不可以为负数");
					return _reward = 0;
				}//else 

				return _reward;
			}
			set { _reward = value; }
		}
		private DateTime _publishDateTime;
		public DateTime PublishDateTime { get; set; }

		private User _author;
		public User Author { get; set; }

		//private 私有的
		//internal 内部的，只能再项目内部进行访问
		public static void Publish(User user)
		{

		}



		//考虑求助（Problem）的以下方法/属性，哪些适合实例，哪些适合静态，然后添加到类中：

		//    Publish()：发布一篇求助，并将其保存到数据库
		//	Load(int Id)：根据Id从数据库获取一条求助
		//	Delete(int Id)：根据Id删除某个求助
		//	repoistory：可用于在底层实现上述方法和数据库的连接操作等
		public static void Load(int Id)
		{ 
		
		}
		
		public void Delete(int Id)//适合实例，可以根据对象的实例进行删除
		{
		}
		public static void repoistory()
		{ 
		
		}

	}
}
