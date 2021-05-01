using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class Problem
	{
		/*求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、
		发布时间（PublishDateTime）和作者（Author），和方法Publish()*/
		public  string Title;
		public string Body;
		public int  Reward;
		public DateTime PublishDateTime;
		public User Author;
		//private 私有的
		//internal 内部的，只能再项目内部进行访问
		public void Publish()
		{ 
		
		}
	}
}
