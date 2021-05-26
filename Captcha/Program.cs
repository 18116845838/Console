using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Captcha
{
	class Program
	{
		static void Main(string[] args)
		{
			#region  参考一起帮的登录页面，绘制一个验证码图片，存放到当前项目中。验证码应包含：
			//随机字符串
			//混淆用的各色像素点
			//混淆用的直线（或曲线）
			Bitmap bitmap = new Bitmap(120, 50);
			Graphics g = Graphics.FromImage(bitmap);
			string str = Captcha();
			g.Clear(Color.White);
			Random random = new Random();
			for (int i = 0; i < 10; i++)
			{
				g.DrawLine(new Pen(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255))),
				new Point(random.Next(120), 
				random.Next(50)), new Point(random.Next(120), random.Next(50)));
			}		
			g.DrawString(str, new Font("宋体", 20), new SolidBrush(Color.FromArgb
				(random.Next(255), random.Next(255), random.Next(255))), new PointF(30, 15));

			bitmap= Pixel(bitmap);
			bitmap.Save(@"D:\yz\hello\验证码.jpg",ImageFormat.Jpeg);
			Console.WriteLine(str);
			Console.ReadKey();
			#endregion
		}
		#region //验证码生成随机数
		public static string Captcha()
		{
			string num = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
			Random random = new Random();
			string captcha = null;
			Console.WriteLine(num.Length);
			for (int i = 0; i < 4; i++)
			{
				captcha += num.Substring(random.Next(num.Length), 1);
			}
			return captcha;
		}
	
		public static  Bitmap Pixel(Bitmap Bitmap)//随机像素点
		{
			Random random = new Random();
			Random R = new Random();
			for (int i = 0; i <100 ; i++)
			{
				Bitmap.SetPixel(random.Next(Bitmap.Width),
					random.Next(Bitmap.Height),Color.FromArgb
					(R.Next(255), R.Next(255), R.Next(255)));
			}
			return Bitmap;
		}
		#endregion

	}

}
