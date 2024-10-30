
namespace DataStructures
{
	using System;

	namespace SingleList
	{

		// define the singly linked list node
		public class LinkedListNode
		{
			public int data;
			public LinkedListNode next;

			// constructor for the node
			public LinkedListNode(int _data)
			{
				this.data = _data;
				this.next = null;
			}
		}

		// define the linked list iterator
		public class LinkedListIterator
		{
			private LinkedListNode currentNode;

			// default constructor for the iterator
			public LinkedListIterator()
			{
				this.currentNode = null;
			}

			// constructor for the iterator with a starting node
			public LinkedListIterator(LinkedListNode node)
			{
				this.currentNode = node;
			}

			// return the current node's data
			public int data()
			{
				return this.currentNode.data;
			}

			// advance to the next node and return the iterator
			public LinkedListIterator next()
			{
				this.currentNode = this.currentNode.next;
				return this;
			}

			// return the current node
			public LinkedListNode current()
			{
				return this.currentNode;
			}
		}

		public class LinkedList
		{
			private int length;
			public LinkedListNode head = null;
			public LinkedListNode tail = null;

			public void AddHead(LinkedListNode node)
			{
				this.head = node;
				this.tail = node;
			}

			public void InsertLast(int data)
			{
				LinkedListNode newNode = new LinkedListNode(data);
				if (this.head == null)
				{
					this.head = newNode;
					this.tail = newNode;
				}
				else
				{
					this.tail.next = newNode;
					this.tail = newNode;
				}
				this.length++;
			}

			public void InsertAfter(LinkedListNode node, int data)
			{
				LinkedListNode newnode = new LinkedListNode(data);
				newnode.next = node.next;
				node.next = newnode;
				if (newnode.next == null)
				{
					this.tail = newnode;
				}
				this.length++;
			}

			public void DeleteNode(LinkedListNode node)
			{
				if (this.head == this.tail)
				{
					this.head = null;
					this.tail = null;
				}
				else if (this.head == node)
				{
					this.head = node.next;
				}
				else
				{
					LinkedListNode parentNode = this.FindParent(node);

					if (this.tail == node)
					{
						this.tail = parentNode;
					}
					else
					{
						parentNode.next = node.next;
					}
				}
				this.length--;
			}

			public void DeleteNode(int data)
			{
				LinkedListNode node = this.Find(data);
				if (node == null)
				{
					return;
				}
				this.DeleteNode(node);
			}

			public void DeleteHead()
			{
				if (this.head == null)
				{
					return;
				}
				this.DeleteNode(this.head);
			}

			public void InsertBefore(LinkedListNode node, int data)
			{
				LinkedListNode newnode = new LinkedListNode(data);
				newnode.next = node;

				LinkedListNode parentNode = this.FindParent(node);

				if (parentNode == null)
				{
					this.head = newnode;
				}
				else
				{
					parentNode.next = newnode;
				}
				this.length++;
			}

			public LinkedListNode Find(int data)
			{
				for (LinkedListIterator itr = this.Begin(); itr.current() != null; itr.next())
				{
					if (itr.data() == data)
					{
						return itr.current();
					}
				}
				return null;
			}

			public LinkedListNode FindParent(LinkedListNode node)
			{
				for (LinkedListIterator itr = this.Begin(); itr.current() != null; itr.next())
				{
					if (itr.current().next == node)
					{
						return itr.current();
					}
				}
				return null;
			}

			public int GetLengthItr()
			{
				int count = 0;
				for (LinkedListIterator itr = this.Begin(); itr.current() != null; itr.next())
				{
					count++;
				}
				return count;
			}

			public int Length()
			{
				return this.length;
			}

			public void PrintList()
			{
				for (LinkedListIterator itr = this.Begin(); itr.current() != null; itr.next())
				{
					Console.Write(itr.data() + " -> ");
				}
				Console.Write("\n");
			}

			public int Sum()
			{
				int sum = 0;
				for (LinkedListIterator itr = this.Begin(); itr.current() != null; itr.next())
				{
					sum += itr.data();
				}
				return sum;
			}

			public LinkedListIterator Begin()
			{
				LinkedListIterator itr = new LinkedListIterator(this.head);
				return itr;
			}
		}
	}
}
