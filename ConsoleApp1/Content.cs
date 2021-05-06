using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class Content
	{
		//观察一起帮的求助（problem）、文章（Article）和意见建议（suggest），根据他们的特点，抽象出一个父类
		//内容（Coutent）
		//	1	Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
		//	2确保每个Content对象都有kind的非空值
		//	3Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
		//	4其他方法和属性请自行考虑，尽量贴近一起帮的功能实现。

		//5实例化文章和意见建议，调用他们：

		// .1继承自父类的属性和方法
		// .2自己的属性和方法

		//6再为之前所有类（含User、HelpMoney等）抽象一个基类：Entity，包含一个只读的Id属性。试一试，Suggest能有Id属性么？ 

		private string _kind;
		public int age;
		private DateTime _createTime;
		public DateTime PublishTime
		{
			get { return _createTime; }
			//set { }
		}

		protected string Kind//kind不能为空值,只能让子类使用
		{
			get
			{
				if (_kind == null)
				{
					_kind = "";
				}//else 
				return _kind;
			}
			set
			{
				_kind = value;
			}
		}
		public Content ()
		{
			_kind = Kind;
		}
		public void publish()
		{ 
		
		}


	}
}
