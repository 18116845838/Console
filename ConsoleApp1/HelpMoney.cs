using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{
	///帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法

	///为这些类的字段和方法设置合适的访问修饰符。 
	///

	
	class HelpMoney: Entity<HelpMoney>
	{

		public HelpMoney()
		{

		}
		private DateTime _time;
		private int _usable;
		private bool _freeze;
		private string _kind;
		private int _change;
		private string _comment;



		/// <summary>
		/// 帮帮币内的属性
		/// </summary>
		/// <param name="usable">可用数量</param>
		/// <param name="change">变动</param>
		/// <param name="comment">备注</param>
		/// <param name="kind">种类</param>
		/// <param name="freeze">冻结</param>
		/// 

		public HelpMoney(int usable, int change, string comment = "打赏", string kind = "交易", bool freeze = true)
		{
			Usable = usable;
			Change = change;
			Comment = comment;
			Kind = kind;
			Freeze = freeze;
		}
		//时间
		public DateTime Time { get; set; }

		//可用 
		public int Usable { get; set; }
		//冻结
		public bool Freeze { get; set; }

		//种类
		public string Kind { get; set; }

		//变化
		public int Change { get; set; }

		//备注
		public string Comment { get; set; }
	
		public int gain(int num)
		{

			return 0;
		}
		public void freeze()
		{

		}



	}
}
