using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;
using NUnit.Framework;

namespace TestProject1
{
	public class DLinkNodeTest
	{
		private DLinkNode<int> node1, node2, node3, node4, node5, node6;
		[SetUp]
		public void SetUp()
		{
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
		{   // 1 2 3 4
			node3.AddAfter(node4);//在后面添加节点
			Assert.AreEqual(node3, node4.Previous);
			Assert.AreEqual(node4, node3.Next);
			Assert.IsNull(node4.Next);
			// 1 2 3 4 5
			node4.AddAfter(node5);
			Assert.AreEqual(node3, node4.Previous);
			Assert.AreEqual(node5, node4.Next);
			Assert.AreEqual(node4, node5.Previous);
			Assert.AreEqual(null, node5.Next);

			//测试在前面添加节点
			// 6 1 2 3 4 5
			node1.AddBefor(node6);
			Assert.IsNull(node6.Previous);
			Assert.AreEqual(node6, node1.Previous);
			Assert.AreEqual(node1, node6.Next);
			Assert.AreEqual(node1, node2.Previous);
			Assert.AreEqual(node2, node1.Next);
			Assert.AreEqual(node2, node3.Previous);
		}
		[Test]//测试删除节点
		public void DeleteTest()
		{
			// [1] 2 3 
			node1.Delete(node1);
			Assert.IsNull(node1.Previous);
			Assert.IsNull(node1.Next);
			Assert.AreEqual(node2,node3.Previous);
			Assert.AreEqual(node3, node2.Next);
		}
		[Test]
		public void SwapTest()//测试交换节点
		{
			node3.AddAfter(node4);//先添加一个node4和node5
			node4.AddAfter(node5);//       1 2 3 4 5
								  //交换 --1 4 3 2 5
			node2.Swap(node4);					 
			Assert.AreEqual(null,node1.Previous);
			Assert.AreEqual(node1,node4.Previous);
			Assert.AreEqual(node4,node1.Next);
			Assert.AreEqual(node4,node3.Previous);
			Assert.AreEqual(node3,node4.Next);
			Assert.AreEqual(node3,node2.Previous);
			Assert.AreEqual(node2,node3.Next);
			Assert.AreEqual(node2,node5.Previous);
			Assert.AreEqual(node5, node2.Next);
			Assert.AreEqual(null, node5.Next);

			//交换--头部为null值   2 4 3 1 5
			node1.Swap(node2);
			Assert.AreEqual(null,node2.Previous); 
			Assert.AreEqual(node2,node4.Previous); 
			Assert.AreEqual(node4,node2.Next); 
			Assert.AreEqual(node4,node3.Previous); 
			Assert.AreEqual(node3,node4.Next); 
			Assert.AreEqual(node3,node1.Previous); 
			Assert.AreEqual(node1,node3.Next); 
			Assert.AreEqual(node1,node5.Previous); 
			Assert.AreEqual(node5,node1.Next); 
			Assert.AreEqual(null,node5.Next);

			//交换--末尾为null值 2 5 3 1 4
			node4.Swap(node5);
			Assert.AreEqual(null, node2.Previous);
			Assert.AreEqual(node2, node5.Previous);
			Assert.AreEqual(node5, node2.Next);
			Assert.AreEqual(node5, node3.Previous);
			Assert.AreEqual(node3, node5.Next);
			Assert.AreEqual(node3, node1.Previous);
			Assert.AreEqual(node1, node3.Next);
			Assert.AreEqual(node1, node4.Previous);
			Assert.AreEqual(node4, node1.Next);
			Assert.AreEqual(null, node4.Next);

		}
		[Test]
		public void FindByTest()//根据节点查找某个节点
		{

		}
		[Test]
		public void ForeachTest()//测试foreach实现双向链表
		{
			node3.AddAfter(node4);
			node4.AddAfter(node5);
			node5.AddAfter(node6);

			List<DLinkNode<int>> nodes = new List<DLinkNode<int>>() /*{ node1,node2,node3,node4,node5,node6}*/;


			foreach (DLinkNode<int> item in node1)
			{
				nodes.Add(item);
			}
			// 1 2 3 4 5 6
			Assert.AreEqual(nodes.Count, 6);
			Assert.AreEqual(node1.Value, nodes[0].Value);
			Assert.AreEqual(node2.Value, nodes[1].Value);
			Assert.AreEqual(node3.Value, nodes[2].Value);
			Assert.AreEqual(node4.Value, nodes[3].Value);
			Assert.AreEqual(node5.Value, nodes[4].Value);
			Assert.AreEqual(node6.Value, nodes[5].Value);
		}
		[Test]
		public void MaxNode()//扩展方法测试
		{
			node3.AddAfter(node4);
			node4.AddAfter(node5);
			node5.AddAfter(node6);

			List<DLinkNode<int>> nodes = new List<DLinkNode<int>>() { node1, node2, node3, node4, node5, node6 };
			node1.Maxnode();
			Assert.AreEqual(6, node1.Maxnode().Value);
		}
	}
}
