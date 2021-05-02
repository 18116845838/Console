using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class Problem
	{
		/*求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、
		发布时间（PublishDateTime）和作者（Author），和方法Publish()*/
		private  string _title;
		public string Title {
			get { return _title; }
			set { _title = value; }
		
		}
		private string _body;
		public string Body
		{
			get { return _body; }
			set { _body = value; }
		}
		private int  _reward;
		public int Reward
		{
			get
			{
				if (Reward<0)
				{
					Console.WriteLine("悬赏不可以为负数");
					return _reward=0;
				}
				
				return _reward; }
			set { _reward = value; }
		}
		private DateTime _publishDateTime;
		public DateTime PublishDateTime
		{
			get { return _publishDateTime; }
			set { _publishDateTime = value; }
		}
		private User _author;
		public User Author
		{
			get { return _author; }
			set { _author = value; }
		}
		//private 私有的
		//internal 内部的，只能再项目内部进行访问
		public void Publish()
		{ 
		
		}
	}
}
