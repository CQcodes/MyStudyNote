using System;

namespace DataStructure
{
    public partial class BinaryTree
    {
        public void InOrderTraversalRecurssive(Node node)
        {
            if (node != null)
            {
                InOrderTraversalRecurssive(node.LeftChild);
                Console.WriteLine(node.Data);
                InOrderTraversalRecurssive(node.RightChild);
            }
        }
    }
}
