
using System;
namespace LinkedListsDSATutorial4th
{
	public class LinkedList
	{
		public Node First { get; set; }
		public int test { get; set; } = 42;

		//The inserting into the head is a O(1) operation
		public void InsertFirst(int data)
		{
			//Create the node
			Node newNode = new Node();
			//Put data inside node
			newNode.Data = data;
			//put the old node in next
			newNode.Next = First;
			//Make the head the new node
			First = newNode;


		}

		public Node DeleteFirst()
		{	//assing a temporary variable
			Node temp = First;
			//assign the next node
			First = First.Next;
			//make the first the new node
			return temp;

		}


		public void DisplayList()
		{
			Console.WriteLine("Iterating through list");
			Node current = First;
			//once current is null it will stop, otherwise would go infinitly 
			while (current != null)
			{
				current.DisplayNode();
				current = current.Next;


			}
		}

		public void InsertLast(int data)
		{
			Node current = First;
			while(current.Next != null)
			{
				current = current.Next;
			}
			Node newNode = new Node();
			newNode.Data = data;

			current.Next = newNode;


		}
		
	}
}

