using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LInked_List
{
	internal class QueueAsLinkedList
	{
		private LinkedList Queue;
        public QueueAsLinkedList()
        {
            Queue = new LinkedList();
        }

        public void EnQueue(int data)
        {
            Queue.InsertLast(data);

        }
        public int DeQueue()
        {
            int queueData = Queue.Head.data;
            Queue.DeleteHead();
            return queueData;

        }

        public int Peek()
        {
            return Queue.Head.data;
        }
        public bool IsEmpty()
        {
            if(Queue.length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Size()
        {
            return Queue.length;
        }

        public void Print()
        {
            Queue.PrintList();
        }
    }
}
