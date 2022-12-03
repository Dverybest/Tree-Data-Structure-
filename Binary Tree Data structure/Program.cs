// See https://aka.ms/new-console-template for more information
using Binary_Tree_Data_structure;

internal class Program
{
    private static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();

        Console.WriteLine("\n-----PreOrderTravsal With loop-----\n");
        tree.PreOrderTravsal();

        Console.WriteLine("\n-----PreOrderTravsal With Recursion-----\n");

        tree.PreOrderTravsalRecursion(tree.Root);

        Console.WriteLine("\n-----InOrderTravsal With Recursion-----\n");

        tree.InOrderTravsalRecursion(tree.Root);

        Console.WriteLine("\n-----InOrderTravsal With loop-----\n");

        tree.InOrderTravsal();

        Console.WriteLine("\n-----PostOrderTravsalRecursion With Recursion-----\n");

        tree.PostOrderTravsalRecursion(tree.Root);

        Console.WriteLine("\n-----PostOrderTravsalRecursion With loop-----\n");

        tree.PostOrderTravsal();
    }
}