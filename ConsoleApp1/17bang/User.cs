using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	enum PassWordEnum
	{

	}
	/*sealed*/public  class User : Entity<User>, IChat, ISendMessage
	{

		#region ////User类中添加一个Tokens属性，类型为TokenManage
		public TokenManager Tokens { get; set; }
		#endregion

		#region //User类同时继承，将Ichat接口显示实现
		void IChat.Send()
		{
			Console.WriteLine("IChar接口");
		}
		public void Send()
		{
			Console.WriteLine("ISendMessage接口");
		}

		public void Send(EmailMessage emailMessage)
		{
			emailMessage.Send();
		}
		public void Send(DBMessage dBMessageq)
		{
			dBMessageq.Send();
		}
		#endregion

		//作业 
		//让user类无法被继承

		/*观察“一起帮”的：
		注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），
		和方法：Register()、Login()*/

		//////////////////////////////////////////////////////////////////////////////////////////////

		#region ///2：调用这些类的有参/无参构造函数，生成这些类的对象，调用他们的方法 
		//无参函数
		public User()
		{

		}
		public User(string name)
		{
			Name = name;
		}
		#endregion
		#region //每一个User对象一定有Name和Password赋值
		public User(string name, string password)
		{
			Name = name;
			Password = password;
		}
		#endregion
		#region 设计一个适用的机制，能确保用户（User）的昵称（Name）不能含有admin、17bang、管理员等敏感词。 
		#region /1:将之前User/Problem/HelpMoney类的字段封装成属性，其中：
		//user.Password在类的外部只能改不能读
		//如果user.Name为“admin”，输入时修改为“系统管理员”
		//problem.Reward不能为负数
		private string _name;
		public string Name
		{
			get { return _name; }
			set
			{
				if (value.Contains("admin") || value.Contains("17bang") || value.Contains("管理员"))
				{
					Console.WriteLine("用户名不能包含敏感字符");
					return;
				}//else
				if (value == "admin")
				{
					value = "系统管理员";

				}//else
				_name = value;
			}
		}
		#endregion
		#endregion

		#region 字段
		private string _password;
		private User _invitrdBy;
		private string _invitationCode;//邀请码
		#endregion
		#region 属性
		//确保用户（User）的密码（Password）：
		// 长度不低于6
		//必须由大小写英语单词、数字和特殊符号（~!@#$%^&*()_+）组成

		public string Password
		{
			//get { return _password; }
			set
			{
				if (value.Length <= 6)
				{
					Console.WriteLine("密码不能小于六位数");
					return;
				}
				else
				{
					if (!PassWordHasTrue(value))
					{
						Console.WriteLine("密码太简单");
						return;
					}
					//else
				}
				Console.WriteLine(value);
				_password = value;
			}
		}

		public User InvitrdBy { get; set; }
		public string InvitationCode { get; set; }
		#endregion
		#region 一些方法
		public void Register(User user, string InvitationCode)
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
		//必须由大小写英语单词、数字和特殊符号（~!@#$%^&*()_+）组成的方法
		public bool PassWordFormatIsTrue(string password, string passwordFormat)
		{
			for (int i = 0; i < password.Length; i++)
			{
				if (passwordFormat.Contains(password[i]))
				{
					return true;
				}//else 
			}
			return false;
		}
		public bool PassWordHasTrue(string password)
		{
			return
				PassWordFormatIsTrue(password, "~!@#$%^&*()_+") &&
				PassWordFormatIsTrue(password, "QWERTYUIOPASDFGHJKLZXCVBNM") ||
				PassWordFormatIsTrue(password, "qwertyuiopasdfghjklzxcvbnm") &&
				PassWordFormatIsTrue(password, "1234567890");
		}
	}
	#endregion




}

