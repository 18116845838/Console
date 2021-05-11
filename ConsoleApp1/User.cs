using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	sealed class User : Entity, IChat, ISendMessage
	{

		#region ////User类中添加一个Tokens属性，类型为TokenManage
		public TokenManager Tokens { get; set; }
		#endregion

		#region //User类同时继承，将Ichat接口显示实现
		void IChat.Send()
		{
			throw new NotImplementedException();
		}

		public void Send()
		{
			throw new NotImplementedException();
		}
		#endregion

		//作业 
		//让user类无法被继承

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
		//////////////////////////////////////////////////////////////////////////////////////////////




		///2：调用这些类的有参/无参构造函数，生成这些类的对象，调用他们的方法 
		//无参函数
		public User()
		{

		}
		public User(string name)
		{
			Name = name;
		}

		#region //每一个User对象一定有Name和Password赋值
		public User(string name, string password)
		{
			Name = name;
			Password = password;
		}
		#endregion

		private string _name;
		public string Name
		{
			get { return _name; }
			set
			{
				if (value == "admin")
				{
					value = "系统管理员";

				}//else
				_name = value;
			}
		}


		private string _password;
		public string Password
		{
			//get { return _password; }
			set { _password = value; }
		}

		private User _invitrdBy;
		public User InvitrdBy { get; set; }

		private string _invitationCode;//邀请码
		public string InvitationCode { get; set; }


		#region 一些方法
		public /*static*/ void Register(User user, string InvitationCode)
		{
			Console.WriteLine("请输入邀请人！");
			user.InvitrdBy.Name = Console.ReadLine();
			if (user.InvitrdBy.Name != "yefei")
			{
				Console.WriteLine("没有该邀请人！");
				return;
			}
			else
			{
				Console.WriteLine($"请输入邀请码：{InvitationCode}");

				while (true)
				{
					string invitationCode = Console.ReadLine();
					if (InvitationCode != invitationCode)
					{
						Console.WriteLine("验证码错误！请重新输入");

					}
					else
					{
						break;
					}
				}
				Console.WriteLine("请输入用户名！");
				user.Name = Console.ReadLine();
				Console.WriteLine("请输入密码！");
				user.Password = Console.ReadLine();
				Console.WriteLine($"恭喜你注册成功!\n用户名为{user.Name}\n");

			}

		}
		public void Login(User user)
		{
			string Password;
			Console.WriteLine("请输入用户名！");
			user.Name = Console.ReadLine();
			Console.WriteLine("请输入密码！");
			Password = Console.ReadLine();
			if (user.Name != "系统管理员" && Password != "123456")
			{
				Console.WriteLine("用户名或者密码错误！");
			}
			else if (user.Name == "系统管理员" && Password != "123456")
			{
				Console.WriteLine("用户名或者密码错误！");
			}
			else if (Password == "123456" && user.Name != "系统管理员")
			{
				Console.WriteLine("用户名或者密码错误！");
			}
			else
			{
				Console.WriteLine("登录成功！");
			}
		}
		#endregion




	}
}
