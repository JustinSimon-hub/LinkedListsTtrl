using System;
namespace LinkedListsDSATutorial4th
{
	public class Node
	{
		//This is the "node" where the actual data is stored 
		public int Data { get; set; }
		//this is the "arrow" where the reference to the next piece of data is placed 

		public Node? Next { get; set; }

		
		public void DisplayNode()
		{
			Console.WriteLine(Data);
		}
	}	
}

		