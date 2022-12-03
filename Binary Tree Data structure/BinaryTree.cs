using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Binary_Tree_Data_structure
{
	public class BinaryTree
	{
		public Node? Root { get; set; }

		public BinaryTree()
		{
            InitializeTree();
        }

		private void InitializeTree()
		{
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");
            Node nodeG = new Node("G");
            Root = new Node("R")
            {
                Left = nodeA,
                Right = nodeB
            };
            nodeA.Left = nodeC;
            nodeA.Right = nodeD;
            nodeB.Left = nodeE;
            nodeB.Right = nodeF;
            nodeE.Left = nodeG;
        }

        #region Tree Diagram
                    /*
                     *              root(R)
                     *             /    \
                     *        nodeA      nodeB
                     *        /  \         /  \
                     *   nodeC  nodeD  nodeE  nodeF
                     *                  /
                     *             nodeG
                     */
        #endregion

        public void PreOrderTravsal()
        {
            //using loop
      
            if (Root == null) return;

            Stack<Node> stack = new Stack<Node> ();
            stack.Push(Root);
     
            while (stack.Count>0)
            {
                Node current = stack.Pop();
                current.Display();
                if (current.Right != null) stack.Push(current.Right);
                if (current.Left != null) stack.Push(current.Left);
            }
        }
        public void PreOrderTravsalRecursion(Node? root )
        {
            if (root == null) return;
            root.Display();
            PreOrderTravsalRecursion(root.Left);
            PreOrderTravsalRecursion(root.Right);
        }

        public void InOrderTravsal()
        {
            if (Root == null) return;
            Stack<Node> stack  = new Stack<Node>();
            Node? current = Root;
            while (stack.Count>0||current!=null)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }
                Node top = stack.Pop();
                top.Display();
                current = top.Right;
            }
        }

        public void InOrderTravsalRecursion(Node? root)
        {
            if (root == null) return;
            InOrderTravsalRecursion(root.Left);
            root.Display();
            InOrderTravsalRecursion(root.Right);
        }

        public void PostOrderTravsalRecursion(Node? root)
        {
            if (root == null) return;
            PostOrderTravsalRecursion(root.Left);
            PostOrderTravsalRecursion(root.Right);
            root.Display();
        }

        public void PostOrderTravsal()
        {
            if (Root == null) return;
            Stack<Node> stack = new Stack<Node>();
            Node? current = Root;
            bool check = true;
            while (stack.Count > 0 || current != null)
            {
                while (current != null&&check)
                {
                    stack.Push(current);
                    current = current.Left;
                }
                if (stack.Count == 0) return;
                Node top = stack.Peek();

                if (current != top.Right)
                {
                    current = top.Right;
                    check = true;
                    continue;
                }
                top.Display();
                current = stack.Pop();
                check = false;
            }
        }
    }
}

