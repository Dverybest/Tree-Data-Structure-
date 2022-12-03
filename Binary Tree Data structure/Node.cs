using System;
namespace Binary_Tree_Data_structure
{
	public class Node
	{
		public string Data { get; set; }
		public Node? Left { get; set; }
		public Node? Right { get; set; }
		public Node()
		{
		}

        public Node(string data)
        {
            Data = data;
        }
		public string Display()
		{
			Console.Write(Data);
			return Data;
		}
    }
}

