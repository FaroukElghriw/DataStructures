using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LInked_List
{
	internal class StackAsLinkedList
	{
		private LinkedList datalist;

        public StackAsLinkedList()
        {
            datalist = new LinkedList();
        }

        public void Push(int data)
        {
            datalist.InsertFrist(data);
        }

        public int Pop()
        {
            var dataHead = datalist.Head.data;
            datalist.DeleteHead();
            return dataHead;
        }

        public int Peek()
        {
            return datalist.Head.data;
        }
        
        public bool isEmpty()
        {
            return datalist.length <= 0;
        }

        public void Print()
        {
            datalist.PrintList();
        }
        public int Size()
        {
            return datalist.length;
        }
    }
}
