using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LInked_List
{
    internal class LinkedListIterator
    {
        private LinkedListNode currentNode;
        public LinkedListIterator()
        {
            currentNode = null;

        }
       
        public LinkedListIterator(LinkedListNode node)
        {
            currentNode = node;
        }
        public int Data()
            => currentNode.data;

        public LinkedListIterator Next()
        {
            this.currentNode = this.currentNode.Next;
            return this;
        }

        public LinkedListNode Current()
                               => currentNode;

    }
}
