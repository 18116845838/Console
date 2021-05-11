using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	enum Token//	声明一个令牌（Token）枚举
	{
		SuperAdmin = 1,
		Admin = 2,
		Blogger = 4,
		Newbie = 8,
		Registered = 16
	}
	 class TokenManager
	{
		//	声明一个令牌（Token）枚举，包含值：SuperAdmin、Admin、Blogger、Newbie、Registered。
		//声明一个令牌管理（TokenManager）类：
		private Token _tokens;


		//    使用私有的Token枚举_tokens存储所具有的权限
		//	暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和判断其有无某个权限

		public Token Add(Token token)
		{
			return _tokens = _tokens | token;
		}
		public Token Remove(Token token)
		{
			if (Has(token)==true)
			{
				return _tokens = _tokens ^ token;
			}
			else
			{
				Console.WriteLine("没有该权限"); 
				return _tokens;
			}
			
		}
		public bool Has(Token token)
		{
			return _tokens == (_tokens & token);
		}
		
	}
}
