using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	//文章
	class Article:Content
	{


		//列表字段
		private string _list;
		public string List { get; set; }
		public Article()
		{

		}


		//测试调用字段kind
		//Article dan = new Article();
		//public void _kind()
		//{
		//	dan.Kind = "";
		//	Console.WriteLine();
		//}
	}
}
