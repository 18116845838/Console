using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;
using NUnit.Framework;

namespace TestProject1
{
	public class DLinkNodeTest
	{
		private DLinkNode node1, node2, node3, node4, node5, node6;
		[SetUp]
		public void SetUp()
		{
			node1 = new DLinkNode();
			node2 = new DLinkNode();
			node3 = new DLinkNode();
			node4 = new DLinkNode();
			node5 = new DLinkNode();
			node6 = new DLinkNode();
			node1.Previous = null;
			node1.Next = node2;
			node2.Previous = node1;
			node2.Next = node3;
			node3.Previous = node2;

			//node3.Next = node4;
			//node4.Previous = node3;
			//node4.Next = node5;
			//node5.Previous = node4;
			//node5.Next = node6;
			//node6.Previous = node5;
			//node6.Next = null;

		}
		[Test]//测试添加节点
		public void AddAfterTest()
		{
			node3.AddAfter(node4);//在后面添加节点
			Assert.AreEqual(node3, node4.Previous);
			Assert.AreEqual(node4,node3.Next);
			Assert.IsNull(node4.Next);

			node2.AddAfter(node5);
			Assert.AreEqual(node3, node5.Next);
			Assert.AreEqual(node3, node5.Next);

			//测试在前面添加节点
			node1.AddBefor(node6);
			Assert.AreEqual(node6, node1.Previous);
			Assert.AreEqual(node1, node6.Next);

		}
		[Test]//测试删除节点
		public void DeleteTest()
		{
			node2.Delete(node2);
			Assert.IsNull(node2.Previous);
			Assert.AreEqual(node1.Next, node3);
			Assert.AreEqual(node1,node3.Previous);
			Assert.AreEqual(node3,node1.Next);
			node1.Delete(node1);
			Assert.AreEqual(node3.Previous, null);
			Assert.AreEqual(node3.Next, null);
			Assert.AreEqual(node1.Next, null);
			Assert.AreEqual(null, node1.Previous);

		}
		[Test]
		public void SwapTest()//测试交换节点
		{
			//Assert.AreEqual(node1.Previous, null);
			//node2.Swap(node3);
			//Assert.AreEqual(node2.Previous, node3);
			//Assert.AreEqual(node2.Next, node4);
			//Assert.AreEqual(node3.Next, node2);
			//Assert.AreEqual(node1, node3.Previous);
			//Assert.AreEqual(node1.Next,node3);

			//1,[4],3,[2],5
			//node2.Swap(node4);
			//Assert.AreEqual(node1.Next, node4); 
			//Assert.AreEqual(node1, node4.Previous);

			//Assert.AreEqual(node3.Next, node2);
			//Assert.AreEqual(node2.Previous, node3);
			//Assert.AreEqual(node2.Next, node5);
			//Assert.AreEqual(node5.Previous,node2);
			//Assert.AreEqual(node4, node3.Previous);


		}
		[Test]
		public void FindByTest()//根据节点查找某个节点
		{ 
		
		}
	}
}
