using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	///帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法

	///为这些类的字段和方法设置合适的访问修饰符。 
	///

	public class HelpMoney
	{
		private DateTime _time;
		public DateTime TIme
		{
			get { return _time; }
			set { _time = value; }
		}
		private int _usable;
		public int Usable
		{
			get { return _usable; }
			set { _usable = value; }
		}
		private bool _freeze;
		public bool Freeze
		{
			get { return _freeze; }
			set { _freeze = value; }

		}

		private string _kind;
		public string Kind
		{
			get { return _kind; }
			set { _kind = value; }

		}

		private int _change;
		public int Change
		{
			get { return _change; }
			set { _change = value; }
		
		}
		private string _comment;
		public string Comment
		{
			get { return _comment; }
			set { _comment = value; }
		}

	}
}
