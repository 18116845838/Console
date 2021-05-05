using System;
using System.Collections.Generic;
using System.Text;

namespace SelfStudy
{
	/*public*/
	class User
	{
		private static User _name;
		/*private*/public User()
		{

		}
		public static  User sam()
		{
			if (_name==null)
			{
				_name = new User();

			}
			return _name;
		}

		//public User()
		//{
		//	Console.WriteLine();
		//}
		////受保护的
		//protected int sam;
		
		//public User(string a,int b,int c)
		//{ 
		
		//}
		//private string _name;
		//public string Name { get; set; }
		//private int _nam;
		//public int Nam { get; set; }
		//public void users()
		//{ 
		
		//}

	}
}
