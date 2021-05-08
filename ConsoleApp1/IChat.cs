using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	interface IChat
	{
		//  一起帮还可以在好友间发私信，所有又有了IChat接口，其中也有一个Send()方法声明。
		//  假设User类同时继承了ISendMessage和IChat，如何处理？//  将其中一个接口或者两个同时显示实现
		void Send();
	}
}
