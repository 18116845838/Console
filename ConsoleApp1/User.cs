using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class User
	{
		/*观察“一起帮”的：
		注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），
		和方法：Register()、Login()*/
		public  string  Name;
		public string  Password;
		public  User InvitrdBy;
		public bool Register()
		{
			return true;
		}
		public  bool Login()
		{
			return true;
		}

	}
}
