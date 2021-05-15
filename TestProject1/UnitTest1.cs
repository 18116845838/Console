using System;
using NUnit.Framework;
using ConsoleApp1.Invoke;

namespace TestProject1
{
	public class Tests
	{
		//	为之前作业添加单元测试，包括但不限于：

		//   数组中找到最大值
		//找到100以内的所有质数
		//猜数字游戏
		//二分查找
		//栈的压入弹出

		[SetUp]
		public void Setup()
		{
			
		}

		[Test]
		public void Test1()
		{
			//数组中找到最大值
			Assert.AreEqual(12112, HWMethod.Max(new int[] { 1117, 23, 4, 5, 65, 787, 9, 32, 12, 12112 }));
			Assert.AreEqual(1117, HWMethod.Max(new int[] { 1117, 23, 4, 5, 65, 787, 9, 32, 12, 12 }));
			Assert.AreEqual(787, HWMethod.Max(new int[] { 7, 23, 4, 5, 65, 787, 9, 32, 12, 12 }));
		
		}

		[Test]
		public void Test2()
		{
			//找到一百以内的质数
			//检查个数是否相同
			int[] number=new int[HWMethod.PrimeNumber()];

			//number = HWMethod.PrimeNumber();
			Assert.AreEqual(25,number.Length);

			//检查是不是质数
			Assert.IsTrue(HWMethod.ISPrimeNumber(5));
			Assert.IsTrue(HWMethod.ISPrimeNumber(17));
			Assert.IsTrue(HWMethod.ISPrimeNumber(19));
			Assert.IsTrue(HWMethod.ISPrimeNumber(3));
		}
		[Test]
		public void Test3()
		{

		}

	}
}