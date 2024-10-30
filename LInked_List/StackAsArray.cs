using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LInked_List
{
	internal class StackAsArray
	{
		private int[] stackArr;
       private int  intialSize;
		private int topIndex;
		
        public StackAsArray()
        {
			intialSize = 5;
			stackArr = new int[intialSize];
			topIndex = -1;
        }
		public void Push(int data)
		{
			stackArr[++topIndex] = data;
		}

		public int Pop()
		{
			return  stackArr[topIndex--];

			
		}

		public int Peek()
		{
			return stackArr[topIndex];
		}

		public bool isEmpty()
		{
			return topIndex == -1;
		}

		public void Print()
		{
			for (int i = 0 ; i <= topIndex; i++)
			{
				Console.WriteLine(stackArr[i]);
			}
		}
		
	}
}
