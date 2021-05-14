using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	//文章
	class Article:Content
	{

		//public override void Agree()
		//{
		//	Console.WriteLine("对文章点赞，增加了帮帮点，作者减少了帮帮点");
		//}
		//public override void Disagree()
		//{
		//	Console.WriteLine("对文章点踩，增加了帮帮点，作者增加了帮帮点");
		//}


		//多态作业
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


		//列表字段
		private string _list;
		public string List { get; set; }


		//测试调用字段kind
		//Article dan = new Article();
		//public void _kind()
		//{
		//	dan.Kind = "";
		//	Console.WriteLine();
		//}
	}
}
