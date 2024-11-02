using DataStructures.LInked_List;
using DataStructures.Operations;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
			#region Array
			//int[] arr = { 1, 2, 3, 4 };
			//ArrayOPerations ourArr = new ArrayOPerations();
			//ourArr.Resize(ref arr, 10);
			//Console.WriteLine(string.Join(", ", arr));
			#endregion
			#region LinKedList
			//LInked_List.LinkedList List = new LInked_List.LinkedList();

			//List.InsertLast(1);
			//List.InsertLast(2);
			//List.InsertLast(3);
			//List.InsertLast(4);
			//List.PrintList();

			//List.InsertAfter(List.Find(3), 45);
			//List.PrintList();

			//List.InsertBefore(List.Find(45), 44);
			//List.PrintList();
			//SingleList.LinkedList list = new SingleList.LinkedList();
			//list.InsertLast(1);
			//list.InsertLast(2);
			//list.InsertLast(3);
			//list.PrintList();

			//         DobulyLinkedList list = new DobulyLinkedList();
			//list.InsertLast(1);
			//list.InsertLast(2);
			//list.InsertLast(3);
			//list.InsertLast(4);
			// list.PrintList();

			//list.InsertAfter(list.Find(3), 45);
			//List.PrintList();
			#endregion
			#region Stack
			//  StackAsLinkedList stackList= new StackAsLinkedList();
			// Console.WriteLine(stackList.isEmpty());

			//         stackList.Push(12);
			//stackList.Push(30);
			//stackList.Push(40);
			//         Console.WriteLine(stackList.isEmpty());

			//         Console.WriteLine(stackList.Size());

			//         stackList.Print();
			//         Console.WriteLine($"Pop : {stackList.Pop()}");
			//         Console.WriteLine($"size: {stackList.Size()}");
			//         stackList.Print();
			//         Console.WriteLine(stackList.Peek());
			//Console.WriteLine($"size: {stackList.Size()}");
			//         while (!stackList.isEmpty())
			//         {
			//	Console.WriteLine($"Pop : {stackList.Pop()}");
			//	       Console.WriteLine($"size: {stackList.Size()}");
			//	       stackList.Print();
			//}

			//StackAsArray stackData= new StackAsArray();
			//stackData.Push(5);
			//stackData.Push(6);
			//stackData.Push(7);
			//stackData.Print();

			//Console.WriteLine(stackData.Pop());
			#endregion
			#region Queue
			//         QueueAsLinkedList queue = new QueueAsLinkedList();
			//         Console.WriteLine(queue.IsEmpty());
			//         queue.EnQueue(8);
			//         queue.EnQueue(20);
			//         queue.EnQueue(30);
			//         queue.EnQueue(40);
			//Console.WriteLine(queue.IsEmpty());
			//         queue.Print();
			//         Console.WriteLine(queue.Size());

			//         while (!queue.IsEmpty())
			//         {
			//             Console.WriteLine($"Peek : {queue.Peek()}");
			//	Console.WriteLine($"Dequeue : {queue.DeQueue()}");
			//             Console.WriteLine($"Size : {queue.Size()}");
			//             Console.WriteLine("============");
			//         }

			#endregion
			#region Dicitionary
			//Dicitionary<string,string> dic=new Dicitionary<string,string>();
			//dic.Print();
			//dic.Set("Sinar", "sinar@gmail.com");
			//dic.Set("Elvis", "elvis@gmail.com");
			//dic.Print();

			//dic.Set("Tane", "tane@gmail.com");
			//dic.Set("Gerti", "gerti@gmail.com");
			//dic.Set("Arist", "arist@gmail.com");

			//dic.Set("rArist", "rarist@gmail.com");
			// dic.Set("tArist", "tarist@gmail.com");
			// dic.Set("yArist", "yarist@gmail.com");
			//dic.Print();

			//         Console.WriteLine(dic.Get("Tane"));
			//         Console.WriteLine(dic.Get("Ail"));
			//dic.Remove("Sinar");
			//dic.Remove("Elvis");
			//dic.Remove("Tane");
			//dic.Print();
			#endregion
			#region Hashing

			//Hashing.Hash32("This is Original Text");
			//Hashing.Hash32("this is Original Text"); // as Hashing is key Senstive if we change simple the output will chnage
			//         Console.WriteLine("Hashing with 64 bit");
			//Hashing.Hash64("This is Original Text");
			//Hashing.Hash64("this is Original Text");
			#endregion
			#region HashTable
			//HashTable<string, string> table = new HashTable<string, string>();
			//table.Print();
			//table.Set("Sinar", "sinar@gmail.com");
			//table.Set("Elvis", "elvis@gmail.com");
			//table.Set("Tane", "tane@gmail.com");
			//table.Print();
			//Console.WriteLine("[get] " + table.Get("Sinar"));
			//Console.WriteLine("[get] " + table.Get("Tane"));
			//table.Set("Gerti", "gerti@gmail.com");
			//table.Set("Arist", "arist@gmail.com");
			//table.Print();
			//Console.WriteLine("[get] " + table.Get("Sinar"));
			#endregion
			#region BinaryTree
			BinaryTree<char> tree = new BinaryTree<char>();
			tree.BreadthFirstInsertion('A');
			tree.BreadthFirstInsertion('B');
			tree.BreadthFirstInsertion('C');
			tree.BreadthFirstInsertion('D');
			tree.BreadthFirstInsertion('E');
			tree.BreadthFirstInsertion('F');
			tree.BreadthFirstInsertion('G');
			tree.BreadthFirstInsertion('H');
			tree.BreadthFirstInsertion('I');
			tree.Print();
			Console.WriteLine($"Height : {tree.Height()}");
			tree.PreOrderTraversal();
			tree.InOrderTraversal();
			tree.PostOrderTravsel();
			#endregion
		}
	}
}