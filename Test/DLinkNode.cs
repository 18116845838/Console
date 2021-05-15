using System;
using System.Collections.Generic;
using System.Text;

namespace SelfStudy
{
	public  class DLinkNode
	{
		public DLinkNode Previous { get;set; }
		public DLinkNode Next { get;set; }
		public void AddAfter(DLinkNode node)
		{
			this.Next = node;
			node.Previous = this;
		}
		public void AddBefore()
		{ 
		 }
		public void Delete(DLinkNode dLinkNode)
		{ 
		
		}
		public void Span(DLinkNode dLinkNode)
		{ 
		
		}
	}
}
