using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	//意见建议
	class Suggest:ContentService
	{
		//多态作业
		public override void Publish()
		{
			base.Publish();
		}

		public Suggest()
		{
			Console.WriteLine("不消耗帮帮币");
		}
		//留言字段
		private string _message;
		public string Message { get; set; }
	}
}
