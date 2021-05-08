using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	//意见建议
	 class Suggest:Content
	{

		public override void Agree()
		{
			Console.WriteLine("对意见建议点赞，增加了帮帮点，作者增加了帮帮点");
		}

		public override void Disagree()
		{
			Console.WriteLine("对意见建议点踩，增加了帮帮点，作者减少了帮帮点");
		}

		//多态作业
		//public override void Publish()
		//{
		//	base.Publish();
		//}



		public Suggest()
		{
			Console.WriteLine("不消耗帮帮币");
		}

		//留言字段
		private string _message;
		public string Message { get; set; }
	}
}
