using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LInked_List
{
	internal class DoublyLinkedListNode
	{
		public int data;
		public DoublyLinkedListNode Next;
		public DoublyLinkedListNode Back;

		public DoublyLinkedListNode(int _data)
		{
			data = _data;
			Next = null;
			Back = null;
		}
	}
}
