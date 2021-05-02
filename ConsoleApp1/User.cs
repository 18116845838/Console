using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class User
	{
		////构造函数不需要返回/必须和类名相同/ctor快捷
		//public User()
		//{

		//}
		//public User(string name)
		//{

		//}
		//public User(string name,int age)
		//	:this(name)//调用上面构造函数，复制方法必须和上面函数有相同的参数
		//{
		//	this.age = age;
		//}


		/// //////////////////////////////////////////////////////////////////


		/*观察“一起帮”的：
		注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），
		和方法：Register()、Login()*/


		///////////////////////////////////////////////////////////////////////////////////////
		//1:将之前User/Problem/HelpMoney类的字段封装成属性，其中：

		//user.Password在类的外部只能改不能读
		//如果user.Name为“admin”，输入时修改为“系统管理员”

		//problem.Reward不能为负数

		private string _name;
		public string Name
		{
			get { return _name; }
			set {
				if (value=="admin")
				{
					_name = "系统管理员";
				}
				_name = value; }
		}


		private string _password;
		public string Password
		{
			set { _password = value; }
		}

		private User _invitrdBy;
		public User InvitrdBy
		{
			get { return _invitrdBy; }
			set { _invitrdBy = value; }
		}






		/// //////////////////////////////////////////////////////////////////////////////////////////////
		public void Register()
		{

		}
		public void Login()
		{

		}


	}
}
