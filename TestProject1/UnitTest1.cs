using System;
using NUnit.Framework;
using ConsoleApp1.Invoke;

namespace TestProject1
{
	public class Tests
	{
		//	Ϊ֮ǰ��ҵ��ӵ�Ԫ���ԣ������������ڣ�

		//   �������ҵ����ֵ
		//�ҵ�100���ڵ���������
		//��������Ϸ
		//���ֲ���
		//ջ��ѹ�뵯��

		[SetUp]
		public void Setup()
		{
			
		}

		[Test]
		public void Test1()
		{
			//�������ҵ����ֵ
			Assert.AreEqual(12112, HWMethod.Max(new int[] { 1117, 23, 4, 5, 65, 787, 9, 32, 12, 12112 }));
			Assert.AreEqual(1117, HWMethod.Max(new int[] { 1117, 23, 4, 5, 65, 787, 9, 32, 12, 12 }));
			Assert.AreEqual(787, HWMethod.Max(new int[] { 7, 23, 4, 5, 65, 787, 9, 32, 12, 12 }));
		
		}

		[Test]
		public void Test2()
		{
			//�ҵ�һ�����ڵ�����
			//�������Ƿ���ͬ
			int[] number=new int[HWMethod.PrimeNumber()];

			//number = HWMethod.PrimeNumber();
			Assert.AreEqual(25,number.Length);

			//����ǲ�������
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