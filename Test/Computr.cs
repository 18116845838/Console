using System;
using System.Collections.Generic;
using System.Text;

namespace SelfStudy
{
	abstract  class  Computr
	{
		public abstract/*virtual*/ void ride();
		public abstract void whilee();

	}
	class YP:Computr
	{
		public override void ride()
		{
			Console.WriteLine("硬盘正在读取数据");
		}
		public override void whilee()
		{
			Console.WriteLine("硬盘正在写入数据");
		}
	}
	class Mp3:Computr
	{
		public override void ride()
		{
			Console.WriteLine("mp3正在读取数据");
		}
		public override void whilee()
		{
			Console.WriteLine("MP3正在写入数据");
		}
		public  void hallo()
		{
			Console.WriteLine("mp3正在播放音乐");
		}
	}
	class Sj:Computr
	{
		public override void ride()
		{
			Console.WriteLine("手机正在读取数据");	
		}
		public override void whilee()
		{
			Console.WriteLine("手机正在写入数据");
		}
	}
	class my
	{

		private Computr ms;

		internal Computr Ms { get => ms; set => ms = value; }

		public void MOde()
		{
			Ms.ride();

		}
		public void Nide()
		{
			Ms.whilee();
		}

	}
}
