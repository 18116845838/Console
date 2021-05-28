using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha
{
	class CaptchaPicture
	{
		public string InputCaptcha { get; set; }
		#region //验证码生成随机数
		#region //将生成验证码的代码拆分成若干个方法，并为其添加异常机制，要求能够：
		//显式的抛出一个自定义异常
		//捕获并包裹一个被抛出的异常，记入日志文件，然后再次抛出
		//根据不同的异常，给用户相应的友好的异常提示

		//public bool GetCaptcha()
		//{
		//	if (InputCaptcha is null)
		//	{
		//		throw new Exception("验证码不能为空");
		//	}
		//	else
		//	{
		//		if (InputCaptcha!= CaptchaPs())
		//		{
		//			throw new Exception("验证码错误，请从新输入");
		//		}//else
		//	}
		//	return true;
		//}
		//public void Captchap()//生成验证码
		//{
		//	#region  参考一起帮的登录页面，绘制一个验证码图片，存放到当前项目中。验证码应包含：
		//	//随机字符串
		//	//混淆用的各色像素点
		//	//混淆用的直线（或曲线
		//	Bitmap bitmap = new Bitmap(120, 50);
		//	Graphics g = Graphics.FromImage(bitmap);
		//	string str = CaptchaPs();
		//	g.Clear(Color.White);
		//	Random random = new Random();
		//	for (int i = 0; i < 10; i++)
		//	{
		//		g.DrawLine(new Pen(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255))),
		//		new Point(random.Next(120),
		//		random.Next(50)), new Point(random.Next(120), random.Next(50)));
		//	}
		//	g.DrawString(str, new Font("宋体", 20), new SolidBrush(Color.FromArgb
		//		(random.Next(255), random.Next(255), random.Next(255))), new PointF(30, 15));

		//	bitmap = Pixel(bitmap);
		//	bitmap.Save(@"D:\yz\hello\验证码.jpg", ImageFormat.Jpeg);
		//	#endregion
		//}
		#endregion
		#region 在Tast生成画布
		public void BitmapTast()//生成画布
		{
			Bitmap bitmapTast = new Bitmap(130, 60);
			Graphics g = Graphics.FromImage(bitmapTast);
			g.Clear(Color.White);
			BitmapLine(g);
			BitmapPixel(bitmapTast);
			g.DrawString(CaptchaPs(), new Font("宋体", 25), new SolidBrush(Color.FromArgb
				(new Random().Next(255), new Random().Next(255), new Random().Next(255))), new PointF(35, 20));
			Task.Run(() => bitmapTast.Save(@"D:\yz\hello\验证码二号.jpg", ImageFormat.Jpeg));
		}
		public Graphics BitmapLine(Graphics g)//生成线条//使用生成的画布，用两个任务完成：
		{										   //在画布上添加干扰线条
			Random random = new Random();           //在画布上添加干扰点
			for (int i = 0; i < 15; i++)
			{
				g.DrawLine(new Pen(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)))
				, new Point(random.Next(130), random.Next(60)), new Point(random.Next(130), random.Next(60)));
			}
			
			return g;
		}
		public Bitmap BitmapPixel(Bitmap Bitmap)//干扰点
		{
			Random random = new Random();
			for (int i = 0; i < 100; i++)
			{
				Bitmap.SetPixel(random.Next(Bitmap.Width),random.Next(Bitmap.Height),
					Color.FromArgb(random.Next(255),random.Next(255),random.Next(255)));
			}return Bitmap;
		}

		#endregion
		public string CaptchaPs()//生成字符串
		{
			string num = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
			Random random = new Random();
			string captcha = null;
			for (int i = 0; i < 4; i++)
			{
				captcha += num.Substring(random.Next(num.Length), 1);
			}
			return captcha;
		}
		public static Bitmap Pixel(Bitmap Bitmap)//随机像素点
		{
			Random random = new Random();
			Random R = new Random();
			for (int i = 0; i < 100; i++)
			{
				Bitmap.SetPixel(random.Next(Bitmap.Width),
					random.Next(Bitmap.Height), Color.FromArgb
					(R.Next(255), R.Next(255), R.Next(255)));
			}
			return Bitmap;
		}
		#endregion
		#region 现有一个txt文件，里面存放了若干email地址，使用分号（;）或者换行进行了分隔。
		//请删除其中重复的email地址，并按每30个email一行（行内用;分隔）重新组织
		//public static string Chear(string str)
		//{

		//}
		#endregion
	}
}
