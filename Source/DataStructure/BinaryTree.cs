using System;

namespace DataStructure
{
    public partial class BinaryTree
    {
        public static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            var rootNode = tree.CreateBinaryTree(1);

            //Console.WriteLine("InOrderTraversalRecurssive : ");
            //InOrderTraversalRecurssive(rootNode);

            //Console.WriteLine("PreOrderTraversalIterative : ");
            //PreOrderTraversalIterative(rootNode);

            Console.WriteLine("PostOrderTraversalIterative : ");
            tree.PostOrderTraversalIterative(rootNode);
            Console.ReadLine();
        }
    }
}
