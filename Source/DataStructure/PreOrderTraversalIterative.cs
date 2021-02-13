using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure
{
    public partial class BinaryTree
    {
        public void PreOrderTraversalIterative(Node node)
        {
            var s = new Stack<Node>();

            #region my-logic
            if (node != null)
                s.Push(node);

            while (s.Any())
            {
                var currentNode = s.Pop();
                Console.WriteLine(currentNode.Data);

                if (currentNode.RightChild != null)
                    s.Push(currentNode.RightChild);

                if (currentNode.LeftChild != null)
                    s.Push(currentNode.LeftChild);
            }
            #endregion

            #region video-logic

            //while (node != null || s.Any())
            //{
            //    if (node != null)
            //    {
            //        Console.WriteLine(node.Data);
            //        s.Push(node);

            //        node = node.LeftChild;
            //    }
            //    else
            //    {
            //        node = s.Pop();
            //        node = node.RightChild;
            //    }
            //}

            #endregion
        }
    }
}
