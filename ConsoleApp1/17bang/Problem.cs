using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	  class Problem:Content
	{

		
		#region 多态作业
		public override void Publish()
		{
			Console.WriteLine($"消耗了{_reward}枚帮帮币");
			base.Publish();
		}
		public Problem(int num)
		{
			Reward = num;
		}
		//public override void Agree()
		//{
		//	Console.WriteLine("对求助点赞，减少了帮帮点，作者增加了棒棒点");
		//}

		//public override void Disagree()
		//{
		//	Console.WriteLine("对求助点踩，增加了帮帮点，作者增加了帮帮点");
		//}


		#endregion
		public Problem()
		{

		}
		#region 题目
		/*求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、
		发布时间（PublishDateTime）和作者（Author），和方法Publish()*/
		//一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
		//
		//求助板块索引器
		//考虑求助（Problem）的以下方法/属性，哪些适合实例，哪些适合静态，然后添加到类中：

		//    Publish()：发布一篇求助，并将其保存到数据库
		//	Load(int Id)：根据Id从数据库获取一条求助
		//	Delete(int Id)：根据Id删除某个求助
		//	repoistory：可用于在底层实现上述方法和数据库的连接操作等
		#endregion
		#region //一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
		private string[] help;

		public string this[int index]
		{
			get { return help[index - 1]; }
			set { help[index - 1] = value; }
		}
		#endregion
		#region 每一个Problem对象一定有Body赋值
		/// <summary>
		/// 设置索引器长度
		/// </summary>
		/// <param name="lenth">索引器的长度</param>
		//public Problem(int lenth)
		//{
		//	help = new string[lenth];
		//}
		//	设计一种方式，保证：

		//   
		public Problem(string body)
		{
			_body = body;
		}
		#endregion
		#region //每一个User对象一定有Name和Password赋值

		#endregion
		#region //列表字段
		private string _body;
		private string _title;
		//疑问
		private string _question;
		private int _reward;
		private DateTime _publish;
		//public User Author { get; set; }
		//private User _author;
		private string _list;
		#endregion
		#region 属性
		public string List { get; set; }
		public string Question { get; set; }
		public string Title { get; set; }
		public DateTime PubLish { get; set; }
		public string Body { get; set; }
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
		#endregion
		//public static void Publish(User user)
		//{

		//}
		#region 方法
		public static void Load(int Id)
		{

		}

		public void Delete(int Id)//适合实例，可以根据对象的实例进行删除
		{
		}
		public static void repoistory()
		{

		}
		#endregion
	}
}
