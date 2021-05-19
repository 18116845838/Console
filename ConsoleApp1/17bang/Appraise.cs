using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1._17bang;

namespace ConsoleApp1
{
	public class Appraise
	{
		#region 在现有作业的基础上，观察一起帮的文章板块，以此为蓝本，补充（如果还没有的话）声明：

		//评论（Comment）类
		//评价（Appraise）类：包括“赞（Agree）”和“踩（Disagree）”
		//关键字（Keyword）类
		//并构建以下关系：
		//一篇文章可以有多个评论
		//一个评论必须有一个它所评论的文章
		//每个文章和评论都有一个评价
		//一篇文章可以有多个关键字，一个关键字可以对应多篇文章
		public Article Article { get; set; }
		public Comment comment { get; set; }
		public Appraise Agree { get; set; }//赞
		public Appraise Disagree { get; set; }//踩
		#endregion
	}
}
