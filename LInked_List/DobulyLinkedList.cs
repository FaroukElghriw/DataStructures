using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataStructures.LInked_List
{
	internal class DobulyLinkedList
	{
		public int length;
		public DoublyLinkedListNode Head = null;
		public DoublyLinkedListNode Tail = null;

		public void InsertAfter(DoublyLinkedListNode node,int data)
		{
			DoublyLinkedListNode newNode = new DoublyLinkedListNode(data);
			newNode.Next = node.Next;
			newNode.Back = node;
			node.Next = newNode;
			if(newNode.Next == null)
			{
				this.Tail = newNode;
			}
			else
			{
				newNode.Next.Back = newNode;
			}
		}

		public void InsertLast(int data)
		{
			DoublyLinkedListNode newNode= new DoublyLinkedListNode(data);

			if (Tail is null)
			{
				Tail = newNode;
				Head = newNode;
			}
			else
			{
				newNode.Back = Tail;
				Tail.Next = newNode;
				Tail = newNode;
			}
		}

		//public LinkedListIterator Begin()
		//{
		//	LinkedListIterator itr = new LinkedListIterator(Head);
		//	return itr;
		//}
	}
}
