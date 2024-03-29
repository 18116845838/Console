﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ConsoleApp1._17bang;

namespace ConsoleApp1
{
	public delegate void Opt(int a, int b);
	public class Program
	{
		#region 作业时间结构枚举变量
		enum FromDate
		{
			Days = 1,
			week = 2,
			mouths = 3
		}
		#endregion

		static void Main(string[] args)
		{
			


			#region 在Main()函数调用ContentService时，捕获一切异常，并记录异常的消息和堆栈信息
			try
			{
				new ContentService().Publish(new Content());
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}
			
			#endregion
			#region linQ表达式作业
			//	在之前“文章/评价/评论/用户/关键字”对象模型的基础上，添加相应的数据，然后完成以下操作：
			//   找出“飞哥”发布的文章
			//找出2019年1月1日以后“小鱼”发布的文章
			//按发布时间升序/降序排列显示文章
			//统计每个用户各发布了多少篇文章
			//找出包含关键字“C#”或“.NET”的文章
			//   找出评论数量最多的文章
			//找出每个作者评论数最多的文章
			//将之前作业的Linq查询表达式用Linq方法实现
			User fg = new User() { Name = "飞哥" };//用户
			User xy = new User() { Name = "小鱼" };


			Keyword KCSharp = new Keyword() { Name = "C#" };//关键字
			Keyword KSql = new Keyword() { Name = "sql" };
			Keyword Klinq = new Keyword() { Name = "linq" };
			Keyword kNet = new Keyword() { Name = ".net" };


			Comment comment = new Comment() { Name = "评论1" };//评论
			Comment comment1 = new Comment() { Name = "评论2" };
			Comment comment2 = new Comment() { Name = "评论3" };
			Comment comment3 = new Comment() { Name = "评论4" };
			Comment comment4 = new Comment() { Name = "评论5" };
			IEnumerable<Comment> comments = new List<Comment>() { comment, comment1, comment2, comment3, comment4, };

			//文章 
			Article sql = new Article()
			{
				Author = "飞哥",
				Name = "sql基础",
				User = fg,
				DateTime = new DateTime(2019, 2, 2)
				,
				keywords = new List<Keyword> { KSql },
				//Comments = new List<Comment>()/* { comment,comment1 }*/
			};
			Article linq = new Article()
			{
				Author = "飞哥",
				Name = "linq基础",
				User = fg,
				DateTime = new DateTime(2021, 3, 3),
				keywords = new List<Keyword> { Klinq },
				//Comments = new List<Comment>() /*{ comment,comment2}*/

			};
			Article net = new Article()
			{
				Author = "小鱼",
				Name = ".Net基础"
				,
				User = xy,
				DateTime = new DateTime(2025, 4, 4),
				keywords = new List<Keyword> { kNet },
				Comments = new List<Comment>() /*{ comment, comment1 }*/

			};
			Article cSharp = new Article()
			{
				Author = "飞哥",
				Name = "C#基础",
				User = fg,
				DateTime = new DateTime(2020, 1, 1),
				keywords = new List<Keyword> { KCSharp },
				//Comments = new List<Comment>() /*{ comment, comment1 ,comment3,comment4}*/
			};
			IEnumerable<Article> articles = new List<Article>() { cSharp, sql, linq, net };

			////   找出“飞哥”发布的文章
			//用Linq方法实现
			//var artic = articles.Where(a => a.User == fg);
			//var articl = from a in articles
			//			 where a.User == fg
			//			 select a;
			//foreach (var item in articl)
			//{
			//	Console.WriteLine(item.Name);
			//}

			////找出2019年1月1日以后“小鱼”发布的文章
			//用Linq方法实现
			//var artic = articles.Where(a => a.User == xy && a.DateTime > new DateTime(2019, 1, 1));
			//var articl1 = from a in articles
			//			  where a.User == xy && a.DateTime > new DateTime(2019, 1, 1)
			//			  select a;
			//foreach (var item in artic)
			//{
			//	Console.WriteLine(item.Name);
			//}

			//按发布时间升序/降序排列显示文章
			//用Linq方法实现
			//var artic = articles.OrderByDescending(a => a.DateTime);
			//var artic1 = articles.OrderBy(a => a.DateTime);
			//var articl2 = from a in articles
			//			  orderby a.DateTime descending //降序
			//			  select a;
			//var articl2 = from a in articles
			//			  orderby a.DateTime ascending 升序
			//			  select a;
			//foreach (var item in articl2)
			//{
			//	Console.WriteLine(item.Name+" "+item.DateTime);
			//}

			//统计每个用户各发布了多少篇文章
			//用Linq方法实现
			//var artic = articles.GroupBy(a => new { a.User });
			//var articl3 = articles.GroupBy(a => a.User);
			//var articl3 = from a in articles
			//			  group a by a.User;
			//foreach (var item in artic)
			//{
			//	Console.WriteLine(item.Key.User.Name+ " " + item.Count());
			//}
			//找出包含关键字“C#”或“.NET”的文章
			//用Linq方法实现
			//var artic = articles.Where(a => a.keywords.Any(b => b.Name == "C#" || b.Name == ".net"));
			//var articl4 = from a in articles
			//			  where a.keywords.Any(a => a.Name == "C#" || a.Name == ".net")
			//			  select a;
			//foreach (var item in artic)
			//{
			//	Console.WriteLine(item.Name);
			//}
			//找出评论数量最多的文章
			//用Linq方法实现
			//var artic = articles.OrderByDescending(a=>a.Comments?.Count()).FirstOrDefault();
			//var articl5 = from a in articles
			//		   orderby a.Comments?.Count() descending
			//		   select a.Name;
			//Console.WriteLine(artic.Name);
			//找出每个作者评论数最多的文章
			//用Linq方法实现
			//var artic = articles.GroupBy(a => a.User).
			//	Select(a => a.OrderByDescending(b => b.Comments?.Count()).FirstOrDefault());
			//var articl6 = from a in articles
			//			  group a by a.User into e
			//			  select e.OrderByDescending(e => e.Comments?.Count()).FirstOrDefault();
			//foreach (var item in artic)
			//{
			//	Console.WriteLine($"{item.Name+ item.User.Name}");
			//}
			//找出每个作者最近发布的一篇文章
			//var artic = articles.GroupBy(a => a.User)
			//	.Select(a => a.OrderByDescending(b => b.DateTime).FirstOrDefault());
			//foreach (var item in artic)
			//{
			//	Console.WriteLine(item.User.Name+""+item.Name);
			//}
			#endregion
			#region linq找出每一篇求助的悬赏都大于5个帮帮币的求助作者
			//为求助（Problem）添加悬赏（Reward）属性，并找出每一篇求助的悬赏都大于5个帮帮币的求助作者
			Problem problem = new Problem() { Reward = 5, User = fg };
			Problem problem1 = new Problem() { Reward = 6, User = fg };
			Problem problem2 = new Problem() { Reward = 7, User = fg };
			Problem problem3 = new Problem() { Reward = 8, User = xy };
			IEnumerable<Problem> problems = new List<Problem>() { problem, problem1, problem2, problem3 };
			var pros = problems.Where(p => p.Reward > 5);
			foreach (var item in pros)
			{
				Console.WriteLine(item.User.Name);
			}

			#endregion
			#region //声明一个方法GetWater()，该方法接受ProvideWater作为参数，并能将ProvideWater的返回值输出
			ProvideWater provideWater = new ProvideWater(new Person().RtMax);
			provideWater(new Person());
			provideWater += delegate (Person person) { return 5; };
			provideWater += (Person) => 3;
			Person.GetWater(new Person(), provideWater);
			#endregion

			#region //调用扩展方法Max()：能够返回之前双向链表中存贮着最大值的节点
			DLinkNode<int> node1, node2, node3, node4, node5, node6;
			node1 = new DLinkNode<int>() { Value = 1 };
			node2 = new DLinkNode<int>() { Value = 2 };
			node3 = new DLinkNode<int>() { Value = 3 };
			node4 = new DLinkNode<int>() { Value = 4 };
			node5 = new DLinkNode<int>() { Value = 5 };
			node6 = new DLinkNode<int>() { Value = 6 };
			node1.Previous = null;
			node1.Next = node2;
			node2.Previous = node1;
			node2.Next = node3;
			node3.Previous = node2;

			node3.Next = node4;
			node4.Previous = node3;
			node4.Next = node5;
			node5.Previous = node4;
			node5.Next = node6;
			node6.Previous = node5;
			node6.Next = null;
			Console.WriteLine(node1.Maxnode().Value);

			#endregion

			#region 集合关系构建关系调用
			//Article article1 = new Article();
			//Comment comment = new Comment();
			//Comment comment1 = new Comment();
			//Comment comment2 = new Comment();
			//Comment comment3 = new Comment();
			//Keyword keyword = new Keyword();
			//Appraise appraise = new Appraise();
			//article1.comments = new List<Comment>() { comment, comment1, comment2, comment3 };
			//keyword.Articles = new List<Article>() { article1 };
			//Console.WriteLine(keyword.Articles.Count);
			#endregion
			#region 不使用string自带的Join()方法，定义一个mimicJoin()方法，能将若干字符串用指定的分隔符连接起来，比如
			//：mimicJoin("-","a","b","c","d")，其运行结果为：a-b-c-d 
			Console.WriteLine(Invoke.HWMethod.MimicJoin('?', new string[] { "ss", "dd", "cc" }));
			#endregion
			#region 实现GetCount(string container, string target)方法，可以统计出container中有多少个target
			Console.WriteLine(Invoke.HWMethod.GetCount("12121212121212121212", "121"));
			#endregion
			#region 通过控制台读取用户输入，比如：3月，12周，100天，利用之前作业的GetDate()方法，输出指定时间段后的日期
			Console.WriteLine(Invoke.HWMethod.GetDate(DateTime.Now, "123天"));
			#endregion
			#region 确保用户（User）的密码（Password）必须由大小写英语单词、数字和特殊符号（~!@#$%^&*()_+）组成 
			User user = new User();
			user.Password = "1@S3345323";
			Console.WriteLine(user);
			#endregion

			#region 设计一种模式确保user不能有敏感字符
			//User user = new User();
			//user.Name = "admin";
			//Console.WriteLine(user.Name);
			#endregion

			#region 测试Article不能为空值
			Article article = new Article();
			article.Head = "    ";
			Console.WriteLine(article.Head);
			#endregion

			#region 调用获取特性
			HelpMoneyChangedAttribute.FeatureInformation();
			#endregion

			#region 调用CreateTime,和PublishTime方法
			//之前的Content类，其中的CreateTime（创建时间）和PublishTime（发布时间）都是只读的属性，
			//想一想他们应该在哪里赋值比较好，并完成相应代码
			//反射_createTime字段

			//Content content = new Content();
			//DateTime date = new DateTime(2020, 1, 1);
			//Invoke.HWMethod.AlterCreationtime(content, date);
			//Invoke.HWMethod.AlterpubllishTime(content, date);
			#endregion

			#region //构造一个能装任何数据的数组，并完成数据的读写
			//object[] arrays = { 1, 17.9, "变量", DateTime.Now };
			//arrays = new object[17];
			//Console.WriteLine(arrays[1]);	
			#endregion

			#region //思考dynamic和var的区别，并用代码予以演示
			//var是一种推导类型，是根据变量的内容来决定变量的类型
			//dynamic是一种动态类型，当代码错误是，他逃避了编译时的检查，但在运行时代码就会报错
			//var num = 15;
			//var sam = "shiwu";
			//dynamic nums = 27;
			//dynamic sams = "ershiqi";
			//Console.WriteLine(1-sam);//编译时就会报错
			//Console.WriteLine(21 - sams);//编译时不会报错，运行时报错
			#endregion

			#region //用代码演示struct的类型给是值类型
			//值类型可以直接赋值,无需new出
			//int num = 32;

			//引用类应需要new出来才能使用
			//Program c = new Program();

			//用代码证明struct定义的类型是值类型
			//源栈的学费是按周计费的，所以请实现这两个功能：
			#endregion

			#region GetDate计算日期
			////函数GetDate()，能计算一个日期若干（日 / 周 / 月）后的日期
			//FromDate fromdate = FromDate.Days;
			//Console.WriteLine("请输入日/周/月1：日2：周3：月");
			//bool times = int.TryParse(Console.ReadLine(), out int number);
			//GetDate(fromdate, number);
			//Console.WriteLine("请输入间隔的日期");
			//times = int.TryParse(Console.ReadLine(), out int num);
			//DateTime datetime = new DateTime(2020, 1, 1);
			//GetDate(datetime, num, fromdate);
			#endregion

			#region //给定任意一个年份，就能按周排列显示每周的起始日期，如下图所示：
			//Console.WriteLine("请输入要选择的年份");
			//bool b = int.TryParse(Console.ReadLine(), out int year);
			//DateTime dateTime = new DateTime(year, 1, 1);
			//GetDates(dateTime, year);
			//GetDates(GetDates(dateTime, year));
			#endregion

			#region //错误，修改之前作业Content
			//Content cs = new Suggest();
			//ContentService cf = new ContentService();
			//cf.Publish(cs);
			#endregion

			#region //ISendMessage接口方法调用
			//用Console.WriteLine() 实现Send()。
			//ISendMessage zs = new DBMessage();
			//zs.Send();
			//zs = new EmailMessage();
			//zs.Send();
			////user调用
			//User users = new User();
			//EmailMessage emailMessage = new EmailMessage();
			//DBMessage dBMessage = new DBMessage();
			//users.Send(emailMessage);
			//users.Send(dBMessage);


			//User user = new User();
			//user.Send();
			//ISendMessage sendMessage = new User();
			//IChat chat = new User();
			//chat.Send();
			//user.Send();

			#endregion
			#region //将ContentService抽象类进行调用
			//ContentService lh = new Problem();
			//lh.Agree();
			//lh.Disagree();
			//lh = new Suggest();
			//lh.Agree();
			//lh.Disagree();
			//lh = new Article();
			//lh.Agree();
			//lh.Disagree();
			#endregion
			#region //多态作业调用
			//ContentService lv = new Problem(10);
			//lv.Publish();
			//lv = new Suggest();
			//lv.Publish();
			//lv = new Article();
			//lv.Publish();
			#endregion
			#region //5实例化文章和意见建议，调用他们：
			// .1继承自父类的属性和方法
			// .2自己的属性和方法
			//Article  zzm = new Article();
			//zzm.age = 18;//继承父类的属性
			//zzm.publish();//继承父类的方法
			//zzm.List = "列表";//自己的属性
			//Suggest mmz = new Suggest();
			//mmz.Message = "留言";
			#endregion


			#region //调用单列方法
			//FactoryContext.Singleton();
			#endregion

			#region //用户方法调用
			/*User zs = new User("admin", "123456");
			zs.InvitrdBy = new User();
			string InvitationCode = "1357";

			zs.Register(zs, InvitationCode);
			zs.Login(zs);*/

			//帮帮币
			//HelpMoney ls = new HelpMoney(0,0);
			#endregion

			#region //求助板块索引器
			//Problem we = new Problem(10);
			//we[1] = "C#";
			//we[2]="sql";
			//we[3]="w3c";
			//Console.WriteLine(we[1]);
			#endregion
			#region //用代码和调试过程演示：

			// 值类型参数的值传递
			//int a = 1;
			//int b = 2;
			//a = b;

			//引用类型参数的值传递
			//User lw=new User();
			//lw.Name = "lw";
			//User wx = lw;
			//wx.Name = "wx";
			//值类型参数的引用传递
			//int c = 2;
			//int d = 3;
			//num(ref c,ref d);

			// static int num(ref int a, ref int b)
			//{
			//	int sam = a + b;
			//	return sam;
			//}
			//引用类型参数的引用传递
			//User lw = new User();
			//lw.age = 18;
			//Remarks(ref lw);
			//Console.WriteLine(lw.age);
			//static void Remarks(ref User user)
			//{
			//	user = new User();
			//	user.age++;
			//}
			//return代替引用类型的引用传递
			//User lw = new User();
			//lw.age = 18;
			//lw=Remarks(lw);
			//Console.WriteLine(lw.age);
			//static User Remarks(User user)
			//{
			//	user = new User();
			//	user.age++;
			//	return user;			
			//}
			#endregion
			#region 面向过程作业
			/*			输出两个整数 / 小数的和 / 差 / 积 / 商
	电脑计算并输出：[(23 + 7)x12-8]÷6的小数值（挑战：精确到小数点以后2位）
	想一想以下语句输出的结果：
		int i = 15;
				Console.WriteLine(i++);  15
				i -= 5;
				Console.WriteLine(i);   11
				Console.WriteLine(i >= 10);   ture

				Console.WriteLine("i值的最终结果为：" + i);

				int j = 20;
				Console.WriteLine($"{i}+{j}={i + j}");  11+20=31
				想一想如下代码的结果是什么，并说明原因：
		int a = 10;
				Console.WriteLine(a > 9 && (!(a < 11) || a > 10));  false
				当a为何值时，结果为true？  当a>11时，结果为true
	bool result = (a + 3 > 12) && a < 3.14 * 4 && a != 11;  true
	*/
			/*整数之间的和，……
			 * int num = 4;
			int sam = 2;
			int number = num / sam;
			Console.WriteLine(number);*/


			//小数之间的和……
			// float num = 3.5f;
			////float sam = 1.9f;
			//float number = num * sam;
			//Console.WriteLine(number);

			//float sam = ((23 + 7) * 12 - 8) / 6;
			//Console.WriteLine(Math.Round(sam,2));


			/*int a = 10;
			bool result = (a + 3 > 12) && a < 3.14 * 4 && a != 11;
			Console.WriteLine(result);*/
			/*	观察一起帮登录页面，用if...else ...完成以下功能。

			用户依次由控制台输入：验证码、用户名和密码：

			如果验证码输入错误，直接输出：“*验证码错误”；
			如果用户名不存在，直接输出：“*用户名不存在”；
			如果用户名或密码错误，输出：“*用户名或密码错误”
			以上全部正确无误，输出：“恭喜！登录成功！”
			PS：验证码 / 用户名 / 密码直接预设在源代码中，输入由Console.ReadLine()完成。*/

			/*	Console.WriteLine("请输入验证码qwer");
				string num = Console.ReadLine();
				if (num != "qwer")
				{
					Console.WriteLine("*验证码错误");
				}
				else
				{
					Console.WriteLine("请输入用户名羊生");
					string sam = Console.ReadLine();
					if (sam != "羊生")
					{
						Console.WriteLine("用户名不存在");

					}
					else
					{

						Console.WriteLine("请输入密码123456");
						string number = Console.ReadLine();
						if (number != "123456")
						{
							Console.WriteLine("用户名或者密码错误");
						}
						else
						{
							Console.WriteLine("恭喜你登录成功！");
						}
					}

				}*/

			/*

			将源栈同学姓名 / 昵称分别：
			按进栈时间装入一维数组，
			按座位装入二维数组，
			并输出共有多少名同学。*/

			/*			string[] name = { "夏康平 \n昵称\n2020.2",
							"周丁浩\n昵称\n2020.2",
							"姜鹏\n昵称\n2020.2",
							"刘伟\n昵称\n2020.2",
							"胡涛\n昵称\n2020.2" };

						Console.WriteLine(name[0]);
						string[,] seat = new string[2, 3];
						seat[0, 0] = name[0];
						seat[0, 1] = name[1];
						seat[1, 0] = name[2];
						seat[1, 1] = name[3];
						seat[1, 2] = name[4];
						Console.WriteLine(seat[1, 2]);*/
			//输出共有多少名学生
			//Console.WriteLine("共有" + name.Length + "名学生");


			/*作业：

			
			/*分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9*/
			/*for (int i = 1; i < 6; i++)
			{
				Console.WriteLine(i);
			}
			int i = 1;
			while (i<=9)
			{
				
				Console.WriteLine(i);
				i += 2;
			}*/
			/*用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
			String[] name ={ "夏康平 \n昵称\n2020.2",
/*				"周丁浩\n昵称\n2020.2",
				"姜鹏\n昵称\n2020.2",
				"刘伟\n昵称\n2020.2",
				"胡涛\n昵称\n2020.2" };
			
						for (int i = 0; i < name.Length; i++)
						{
							Console.WriteLine(name[i]);
						}*/


			//二维数组
			/*			string[,] seat = new string[2, 3];

						seat[0, 0] = name[0];
						seat[0, 1] = name[1];
						seat[1, 0] = name[2];
						seat[1, 1] = name[3];
						seat[1, 2] = name[4];

						for (int i = 0; i < 2; i++)
						{
							for (int j = 0; j < 3; j++)
							{

								Console.WriteLine(seat[i, j]);
							}
						}*/



			/*生成一个元素（值随机）从小到大排列的数组*/
			//int[] number = { 1, 3, 6, 2, 8, 6, 9, 13, 24, 5, 14, 55 };

			//for (int i = 0; i < number.Length; i++)
			//{
			//	for (int j = 0; j < number.Length - 1; j++)
			//	{
			//		if (number[j] > number[j + 1])
			//		{
			//			int sam = number[j];
			//			number[j] = number[j + 1];
			//			number[j + 1] = sam;

			//		}//else continue

			//	}

			//}
			//for (int i = 0; i < number.Length; i++)
			//{
			//	Console.WriteLine(number[i]);
			//}



			//设立并显示一个多维数组的值，元素值等于下标之和。Console.Write()

			//创建一个二维数组

			//int[,] number = new int[2, 3];
			//number[0, 0] = 0; number[0, 1] = 1; number[0, 2] = 1;
			//number[1, 0] = 2; number[1, 1] = 2; number[1, 2] = 3;
			//int sam;

			//for (int i = 0; i < number.GetLength(0); i++)
			//{
			//	for (int j = 0; j <number.GetLength(1); j++)
			//	{
			//		sam = number[i, j];
			//		Console.Write(sam);
			//		Console.Write("\t");
			//	}
			//	Console.Write("\n");
			//}

			//二分查找
			/*int[] sam =new int[1000];
			for (int j = 0; j < sam.Length; j++)
			{
				sam[j] = j;
			}
			int num = new Random().Next(1, 1000);
			int left = 0;
			int right = sam.Length;
			int mid = (left + sam.Length) / 2;
			int i = 0;
			while ( i <sam.Length-1)
			{
				i++;
				mid = (left + right) / 2;
				if (num>mid)
				{
					left = mid;
				}
				else if (num<mid)
				{
					right = mid;
				}
				//else
				if(num==mid)
				{
					Console.WriteLine($"数字是{num}查找用了{i+1}次");
					break;
				}//else continue
			}*/



			/*			Console.WriteLine(Math.Round(19.55,1,MidpointRounding.AwayFromZero));
						Console.WriteLine(new Random().Next(100 ,1000));
						int sam = new Random().Next(100, 1000);*/
			/*			Console.WriteLine(sam);*/

			//调用函数，用户猜数字
			/*int sam = new Random().Next(1, 1000);
			Console.WriteLine("请输入一个一到一千之间的整数");
			//Console.WriteLine(GuessMe(sam,0,15));

				GuessMe(sam, 14);*/

			/*利用ref调用Swap()方法交换两个同学的床位号*/
			/*int liu = 2,zhang= 3;
			berth(ref liu, ref zhang );
			Console.WriteLine(liu);*/


			//调用一个方法显示登录信息，比显示登录失败的原因
			/*Console.WriteLine("请输入用户名");
			string name = Console.ReadLine();
			Console.WriteLine("请输入密码");
			int psw = Convert.ToInt32(Console.ReadLine());
			string msg;
			bool b = logOn(name, psw, out msg);
			Console.WriteLine(msg + b);*/
			#endregion
			#region 二分查找
			//实现二分查找，方法名BinarySeek（int【】 numbers，int target）：
			//传入一个有序（从大到小 / 从小到大）数组和数组中要查找的元素
			//  如果找到，返回该元素所在的下标，否则，返回 - 1 *///
			//int[] array = new int[] { 1, 3, 4, 5, 6, 7, 8, 9, 11, 12, 33, 55, 66, 77, 88, 123, 345, 567, 778 };
			//Console.WriteLine(Invoke.HWMethod.BinarySeek(array, 1));

			#endregion
		}

		#region GetDate计算日期
		//static FromDate GetDate(FromDate fromDate, int number)
		//{

		//	switch (number)
		//	{
		//		case 1:
		//			fromDate = FromDate.Days;

		//			break;
		//		case 2:
		//			fromDate = FromDate.week;
		//			break;
		//		case 3:
		//			fromDate = FromDate.mouths;
		//			break;
		//		default:
		//			Console.WriteLine("请输入正确的选项");
		//			break;
		//	}
		//	return fromDate;
		//}
		//static DateTime GetDate(DateTime dateTime, int num, FromDate fromdate)
		//{
		//	switch (fromdate)
		//	{
		//		case FromDate.Days:
		//			dateTime = dateTime.AddDays(num);
		//			break;
		//		case FromDate.week:
		//			dateTime = dateTime.AddDays(num * 7);
		//			break;
		//		case FromDate.mouths:
		//			dateTime = dateTime.AddMonths(num);
		//			break;
		//		default:
		//			Console.WriteLine("请输入正确的数字");
		//			break;
		//	}

		//	return dateTime;
		//}
		#endregion

		#region 结构日期计算排列每周起始日期
		static DateTime GetDates(DateTime dateTime, int year)
		{
			for (int i = 0; i < 6; i++)
			{
				if (dateTime.DayOfWeek == DayOfWeek.Sunday)
				{

					dateTime.AddDays(i);
					return dateTime;
				}
				else
				{
					dateTime = new DateTime(year, 1, 1);
					dateTime = dateTime.AddDays(i);
				}
			}
			return dateTime;
		}
		static DateTime GetDates(DateTime dateTime)
		{
			for (int i = 0; i < 365 / 7; i++)
			{
				Console.WriteLine($"第{i + 1}周：" +
					$"{dateTime.ToString("yyyy年MM月dd日")}--{dateTime.AddDays(6).ToString("yyyy年MM月dd日")}");
				dateTime = dateTime.AddDays(7);
			}
			return dateTime;
		}
		#endregion

		#region 计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
		//int[] sam = { 77, 88, 99, 78, 79, 80 };
		//float num = 0;
		//GetAverage(sam, num);
		//计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
		//完成“猜数字”游戏，方法名GuessMe()：
		/// <summary>
		/// 源栈同学成绩
		/// </summary>
		/// <param name="a">一个包含源栈同学成绩的数组</param>
		/// <param name="b">用来装总成绩</param>
		/// <returns></returns>
		//static int GetAverage(int[] a, float b)
		//{

		//	for (int i = 0; i < a.Length - 1; i++)
		//	{
		//		b = a[i] + b;

		//	}

		//	Console.WriteLine(Math.Round(b / a.Length, 2));
		//	return -1;
		//}
		#endregion

		#region //平均数
		/*int[] sam = { 77, 88, 99, 78, 79, 80 };
		int num = 0;
		for (int i = 0; i < sam.Length - 1; i++)
		{
			num = sam[i] + num;
		}
		Console.WriteLine(num / sam.Length);*/
		//递归
		/*static void getFibonacci(int a,int b) 
		{
			int sam = a + b;
			Console.WriteLine(b);
			getFibonacci(b, sam);

		}*/
		//快速排序
		/*static void QuickSort(int[] nums,int left,int right)
			{
				if (left < right)
				{
					int i = left;
					int j = right - 1;
					int middle = nums[(left + right) / 2];
					while (true)
					{
						while (i < right && nums[i] < middle)
						{
							i++;
						}
						while (j > 0 && nums[j] > middle)
						{
							j--;
						}
						if (i==j)
						{
							break;
						}
						nums[i] = nums[i] + nums[j];
						nums[i] = nums[i] + nums[j];
						nums[j] = nums[i] - nums[j];
						nums[i] = nums[i] - nums[j];
					}

				}
			}*/
		#endregion
		#region /*定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。利用可选参数控制：
		//最小值min（默认为1）
		//相邻两个元素之间的最大差值gap（默认为5）
		//元素个数length（默认为10个）*/
		//调用
		/*int[] max = new int[1];

		Console.WriteLine(GetArray(max, min:4,length: 15));*/
		#endregion

		#region 面向过程剩余作业
		//利用ref调用Swap()方法交换两个同学的床位号
		//static void berth(ref int a, ref int b)
		//{
		//	int tepm = 0;
		//	swap(ref a, ref b, ref tepm);
		//}

		//private static void swap(ref int a, ref int b, ref int tepm)
		//{
		//	tepm = a;
		//	a = b;
		//	b = tepm;
		//}
		/*将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
	true/false，表示登陆是否成功
	string，表示登陆失败的原因*/
		/*		/// <summary>
				/// 判断是否登录成功
				/// </summary>
				/// <param name="name">用户名</param>
				/// <param name="psw">密码</param>
				/// <param name="msg">返回的信息</param>
				/// <returns></returns>*/
		/*static bool logOn(string name, int psw,out string msg)
		{
			if (name == "qwer" && psw == 123456)
			{
				msg = "登录成功";
				return true;

			}
			else if (name=="qwer")
			{
				msg = "密码错误";
				return false;
			}
			else if (psw==123456)
			{
				msg = "用户名错误";
				return false;
			}
			else
			{
				msg = "未知错误";
				return false;
			}

		}*/

		/*定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。利用可选参数控制：

	最小值min（默认为1）
	相邻两个元素之间的最大差值gap（默认为5）
	元素个数length（默认为10个）*/
		#endregion
		#region /// 定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列

		/// </summary>
		/// <param name="max">传入的数组名称</param>
		/// <param name="min">传入z最小值默认1</param>
		/// <param name="gap">定义两个元素的最大差值默认为5</param>
		/// /// <param name="length">数组长度默认10</param>
		/// <returns>返回这个数组</returns>
		public static int GetArray(int[] max, int min = 1, int gap = 5, int length = 10)
		{
			int sam;
			//min = 1;
			max = new int[length];
			for (int i = 0; i < max.Length; i++)
			{

				max[i] = min;
				sam = new Random().Next(1, gap);
				min += gap;
				Console.WriteLine(max[i]);
				return max[i];
			}
			return -1;
		}
		#endregion


	}
}
