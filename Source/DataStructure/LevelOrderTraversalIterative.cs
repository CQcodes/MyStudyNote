using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure
{
    public partial class BinaryTree
    {
        public void LevelOrderTraversalIterative(Node node)
        {
            var s = new Stack<Node>();

            #region my-logic

            //if (node != null)
            //    s.Push(node);

            //while (s.Any())
            //{
            //    var currentNode = s.Pop();

            //    if(currentNode.Data < 0 || (currentNode.RightChild == null && currentNode.LeftChild == null))
            //    {
            //        Console.WriteLine(currentNode.Data * (-1));
            //    }
            //    else
            //    {
            //        // Making the Data negative to indicate this node has been scanned for childs already
            //        currentNode.Data = currentNode.Data * (-1);

            //        s.Push(currentNode);

            //        if (currentNode.RightChild != null)
            //            s.Push(currentNode.RightChild);

            //        if (currentNode.LeftChild != null)
            //            s.Push(currentNode.LeftChild);
            //    }
            //}

            #endregion

            #region video-logic

            var q = new Queue<Node>();
            q.Enqueue(node);

            while (q.Any())
            {
                var currentNode = q.Dequeue();
                Console.WriteLine(node.Data);

                if (currentNode.LeftChild != null)
                    q.Enqueue(currentNode.LeftChild);

                if (currentNode.RightChild != null)
                    q.Enqueue(currentNode.RightChild);
            }

            #endregion
        }
    }
}
