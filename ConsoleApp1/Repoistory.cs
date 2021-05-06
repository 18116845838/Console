using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	 class Repoistory
	{
		//作业：

		//  定义一个仓库（Repoistory）类，用于存取对象，其中包含：
		//      一个int类型的常量version
		//一个静态只读的字符串connection，以后可用于连接数据库
		//思考Respoitory应该是static类还是实例类更好

		const int version = 10;
		private static string _connection;
		//静态只读字符串
		public static string Connection
		{
			get { return _connection; }
			//set { }
		}
	}
}
