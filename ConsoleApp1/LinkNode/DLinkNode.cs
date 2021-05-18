using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class DLinkNode
	{
		//	继续完成双向链表的测试和开发，实现：
		
		//   node3.InsertAfter(node1); 场景
		//InerstBefore()：在某个节点前插入
		//Delete()：删除某个节点
		//[选] Swap()：交互某两个节点
		//[选] FindBy()：根据节点值查找到某个节点

		public DLinkNode Next { get; set; }
		public DLinkNode Previous { get; set; }
		private DLinkNode temp;
		public void AddAfter(DLinkNode node)//在后面添加节点
		{
			if (this.Next != null && this.Previous != null)//插入节点
			{

				this.Next.Previous = node;
				node.Next = this.Next;
			}//else
				this.Next = node;
				node.Previous = this;

		}
		public void AddBefor(DLinkNode node)//在前面添加节点
		{
			if (this.Next != null && this.Previous != null)
			{
				this.Previous.Next = node;
				node.Previous = this.Previous;
			}//else
			this.Previous = node;
			node.Next = this;
		}


		public void Delete(DLinkNode node)//删除节点
		{
			if (node.Previous != null && node.Next != null)//删除中间节点
			{
				node.Next.Previous = node.Previous;
				node.Previous.Next = node.Next;
				node.Next = null;
				node.Previous = null;
			}
			else if (node.Next == null)//删除最后一个节点的情况
			{
				node.Previous.Next = null;
				node.Previous = null;
			}
			else//删除第一个节点
			{
				node.Next.Previous = null;
				node.Next = null;
			}
		}
		public void Swap(DLinkNode node)//交换两个节点
		{
			if (this.Previous != null && node.Next != null)
			{
				node.Next.Previous = this;
				temp = node.Next;
				node.Next = this.Next;
				this.Next.Previous = node;
				this.Next = temp;
				node.Previous.Next = this;
				temp = node.Previous;
				node.Previous = this.Previous;
				this.Previous.Next = node;
				this.Previous = temp;
			}
			else if (this.Previous == null)
			{
				node.Next.Previous = this;
				temp = node.Next;
				node.Next = this.Next;
				this.Next.Previous = node;
				this.Next = temp;
				node.Previous.Next = this;
				temp = node.Previous;
				node.Previous = this.Previous;
				this.Previous = temp;
			}
			else if (node.Next == null)
			{
				this.Next.Previous = node;
				temp = node.Next;
				node.Next = this.Next;
				this.Previous.Next = node;
				this.Next = temp;
				node.Previous.Next = this;
				temp = node.Previous;
				node.Previous = this.Previous;
				this.Previous = temp;
			}
			else if (this.Next==node)
			{

			}



		}
		public void FindBy(DLinkNode node)//根据节点查找某个节点
		{ 
		
		}
	}
}
