using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructures.Operations
{
	internal class Queue<Tdata>
	{
		LinkedList<Tdata> data_list;
		public Queue()
		{
			this.data_list = new LinkedList<Tdata>();
		}
		public void enqueue(Tdata _data)
		{
			this.data_list.AddLast(_data);
		}

		public Tdata dequeue()
		{
			Tdata node_data = this.data_list.First.Value;
			this.data_list.RemoveFirst();
			return node_data;
		}
		public Tdata peek()
		{
			if (this.data_list.First == null)
				return default(Tdata);
			return this.data_list.First.Value;
		}
		public bool hasData()
		{
			if (this.data_list.Count > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public int size() { return this.data_list.Count; }
		//public void print() { this->data_list->printList(); }

	}
}
