using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LInked_List
{
    internal class LinkedListNode
    {
        public int data;
        public LinkedListNode Next;

        public LinkedListNode(int _data)
        {
            data = _data;
            Next = null;
        }

    }
}
