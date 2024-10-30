using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LInked_List
{
	internal class LinkedList
	{
		public int length;
		public LinkedListNode Head = null;
		public LinkedListNode Tail = null;

		public void AddHead(LinkedListNode node)
		{

			Head = node;
			Tail = node;
		}

		public void InsertLast(int data)
		{
			LinkedListNode newNode = new LinkedListNode(data);
			// check for the linkedlist we have item or not
			if (Head == null)
			{
				Head = newNode;
				Tail = newNode;

			}
			else
			{
				Tail.Next = newNode;
				Tail = newNode;
			}
			length++;
		}
		public void InsertFrist(int _data)
		{
			LinkedListNode newNode = new LinkedListNode(_data);
			if(Head  is null)
			{
				Head = newNode;
				Tail=newNode;
			}
			else
			{
				newNode.Next = Head;
				Head= newNode;
			}
			length++;
		}
		public void DeleteHead()
		{
			if(Head == null) 
				return;
			Head=Head.Next;

			length--;
		}

		public void InsertAfter(LinkedListNode node, int data)
		{
			LinkedListNode newNode= new LinkedListNode(data);
			newNode.Next = node.Next;
			node.Next= newNode;
			if(newNode.Next == null)
			{
				Tail = newNode;
			}
			length++;

		}

		public void InsertBefore(LinkedListNode node, int data)
		{
			LinkedListNode newNode= new LinkedListNode(data);
			newNode.Next = node;
			LinkedListNode parentNode = FindParent(node);
			if(parentNode == null)
			{
				Head = newNode;
			}
			else
			{
				parentNode.Next= newNode;
			}
			
			length++;
		}
		public LinkedListNode FindParent(LinkedListNode node)
		{
			for (LinkedListIterator itr = Begin(); itr.Current() != null; itr.Next())
			{
				if (itr.Current().Next==node)
				{
					return itr.Current();
				}

			}
			return null;
		}
		public LinkedListNode Find(int data)
		{
			for(LinkedListIterator itr= Begin(); itr.Current() != null; itr.Next())
			{
				if (itr.Data() == data)
				{
					return itr.Current();
				}
				
			}
			return null;
		}

		public LinkedListIterator Begin()
		{
			LinkedListIterator itr = new LinkedListIterator(Head);
			return itr;
		}
		public void PrintList()
		{
			for (LinkedListIterator itr = this.Begin(); itr.Current() != null; itr.Next())
			{
				Console.Write($"{itr.Data()} ==>");
			}
			Console.Write("\n");
		}

		
	}

}
