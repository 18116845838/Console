using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	///帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法

	///为这些类的字段和方法设置合适的访问修饰符。 
	///


	class HelpMoney: Entity
	{
		public HelpMoney()
		{
		
		}



		/// <summary>
		/// 帮帮币内的属性
		/// </summary>
		/// <param name="usable">可用数量</param>
		/// <param name="change">变动</param>
		/// <param name="comment">备注</param>
		/// <param name="kind">种类</param>
		/// <param name="freeze">冻结</param>
		/// 

		public HelpMoney(int usable,int change ,string comment="打赏",string kind="交易",bool freeze=true)
		{
			Usable = usable;
			Change = change;
			Comment = comment;
			Kind = kind;
			Freeze = freeze;
		}
		//时间
		private DateTime _time;
		public DateTime Time { get; set; }

		//可用 
		private int _usable;
		public int Usable { get; set; }
		//冻结
		private bool _freeze;
		public bool Freeze{get;set;}

		//种类
		private string _kind;
		public string Kind { get; set; }

		//变化
		private int _change;
		public int Change { get; set; }

		//备注
		private string _comment;
		public string Comment { get; set; }

		/*private*/public int gain (int num)
		{

			return 0;
		}
		public void freeze()
		{ 
		
		}



	}
}
