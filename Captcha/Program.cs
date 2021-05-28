using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
			#region 创建一个新的前台线程（Thread），在这个线程上运行生成随机字符串的代码
			Thread thread = new Thread(() => { new CaptchaPicture().CaptchaPs();
				Console.WriteLine("线程ID："+ Thread.CurrentThread.ManagedThreadId);
				Console.WriteLine("Task -ID:" + Task.CurrentId);
			});
			thread.Start();
			//在一个任务（Task）中生成画布
			Task.Run(()=> { new CaptchaPicture().BitmapTast();
				Console.WriteLine("主线程ID："+Thread.CurrentThread.ManagedThreadId);
				Console.WriteLine("Task -ID:" + Task.CurrentId);
			});
			#endregion
			#region 验证码添加异常
			//CaptchaPicture captcha = new CaptchaPicture() { InputCaptcha = "Kr8N" };
			//try
			//{
			//	captcha.GetCaptcha();
			//}
			//catch (Exception e)
			//{
			//	throw e;
			//}
			#endregion
			#region //使用using释放文件资源
			//using (FileStream file=new FileStream(@"D:\yz\hello\debug.log",FileMode.Open))
			//{
			//	byte[] arr = Encoding.UTF8.GetBytes("释放文件资源");
			//	file.Write(arr,0,arr.Length);
			//	file.Flush();
			//}
			#endregion
			Console.ReadKey();


		}

	}

}
