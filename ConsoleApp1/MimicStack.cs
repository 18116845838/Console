using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class MimicStack<T>
	{
		//使用object改造数据结构栈（MimicStack），并在出栈时获得出栈元素

		#region //自己实现一个模拟栈（MimicStack)类，入栈和出栈数据类型为int类型，包含如下功能：
		//1出栈Pop（），弹出栈顶数据
		//2入栈Push()，可以一次性压入多个数据出/
		//3入栈检查，
		//如果压入的数据已超过栈的深度（最大容量），提示“栈溢出”
		//	如果已弹出所有数据，提示“栈已空”
		private /*int*/T[] mimicStack;
		/*private MimicStack */
		public MimicStack(int lenth)
		{
			mimicStack = new T[lenth];
		}
		public int top = 0;

		public void Push(T data)
		{
			if (top <= mimicStack.Length - 1)
			{
				mimicStack[top] = data;
				top++;
			}
			else
			{
				Console.WriteLine("栈溢出");
			}

		}
		public T Pop()
		{
			if (top >0)
			{
				top--;
				Console.WriteLine(mimicStack[top]);
			}
			else
			{
				Console.WriteLine("栈已空");
			}
			return mimicStack[top];
		}
		#endregion


		


	}

}
