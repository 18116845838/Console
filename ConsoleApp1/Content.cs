using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	/*abstract*/
	
	/*abstract*/
	class Content
	{


		//作业：
		//  思考之前的Content类，该将其抽象成抽象类还是接口？为什么？并按你的想法实现。
		//应该使用抽象类，因为接口中无法写字段，而content中存储的有字段



		//  一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/踩（Disagree）的功能，
		//  赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
		//可以抽象,
		//  引入两个子类EmailMessage和DBMessage，和他们继承的接口ISendMessage（含Send()方法声明），
		//  用Console.WriteLine() 实现Send()。
		//  一起帮还可以在好友间发私信，所有又有了IChat接口，其中也有一个Send()方法声明。
		//  假设User类同时继承了ISendMessage和IChat，如何处理？

		//点赞作者增加帮帮点，用户减少
		//public abstract void Agree();

		////点踩作者减少帮帮点，用户增加
		//public abstract void Disagree();






		//观察一起帮的求助（problem）、文章（Article）和意见建议（suggest），根据他们的特点，抽象出一个父类
		//内容（Coutent）
		//	1	Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
		//	2确保每个Content对象都有kind的非空值
		//	3Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
		//	4其他方法和属性请自行考虑，尽量贴近一起帮的功能实现。
		[HelpMoneyChanged(Message = "message")]
		public virtual void Publish()
		{

		}



		//5实例化文章和意见建议，调用他们：

		// .1继承自父类的属性和方法
		// .2自己的属性和方法

		//6再为之前所有类（含User、HelpMoney等）抽象一个基类：Entity，包含一个只读的Id属性。试一试，Suggest能有Id属性么？ 
		//public Content(DateTime dateTime, DateTime publishTime)
		//{
		//	_createTime = dateTime;
		//	publishTime = PublishTime;

		//}
		#region 字段
		private string _kind;
		private DateTime _publishTime;

		private int age = 16;
		private DateTime _createTime=DateTime.Now;
		#endregion

		#region 属性
		public DateTime CreateTime
		{
			get { return _createTime; }
			private set { _createTime = value; }
		}
		public DateTime PublishTime
		{

			get { return _publishTime; }
			private set { _publishTime = value; }
		}
		#endregion

		//protected internal string Kind//kind不能为空值,只能让子类使用
		//{
		//	get
		//	{
		//		if (_kind == null)
		//		{
		//			_kind = "";
		//		}//else 
		//		return _kind;
		//	}
		//	set
		//	{
		//		_kind = value;
		//	}
		//}
		//protected internal string Kind
		//{
		//	get { return _kind; }
		//	set { _kind = value; }
		//}
		//public Content(string Kind)//kind不能为非空值，只能被子类调用
		//{
		//	_kind = Kind;
		//}
		//public abstract void publish();



	}
}
