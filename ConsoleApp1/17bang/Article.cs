using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1._17bang;

namespace ConsoleApp1
{
	//文章
	public class Article:Content
	{
		#region 属性
		public string Name { get; set; }
		public User User { get; set; }
		public List<Comment> Comments { get; set; }
		public Appraise Appraise { get; set; }
		public List<Keyword> keywords { get; set; }
		public DateTime DateTime { get; set; }
		#endregion
		#region 点赞点踩
		//public override void Agree()
		//{
		//	Console.WriteLine("对文章点赞，增加了帮帮点，作者减少了帮帮点");
		//}
		//public override void Disagree()
		//{
		//	Console.WriteLine("对文章点踩，增加了帮帮点，作者增加了帮帮点");
		//}
		#endregion
		#region //多态作业
		public override void Publish()
		{
			base.Publish();
		}

		//public Article(int num=1)
		//{

		//	Console.WriteLine($"消耗{num}枚帮帮币");
		//}
		//public Article()
		//{

		//}
		#endregion
		#region //列表字段
		private string _list;
		public string List { get; set; }
		#endregion
		#region 确保文章（Article）的标题不能为null值，也不能为一个或多个空字符组成的字符串，
		//而且如果标题前后有空格，也予以删除
		private string _head;//标题
		public string Head
		{
			get
			{
				return _head;
			}

			set 
			{
				
				if (string.IsNullOrWhiteSpace(value))
				{
					Console.WriteLine("标题不能为空或含有空字符");
					return;
				}
				//else
				_head = value.Trim();
			}
		}

		public string Author { get; internal set; }

		#endregion
	}

}
