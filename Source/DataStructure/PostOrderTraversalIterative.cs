using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure
{
    public partial class BinaryTree
    {
        public void PostOrderTraversalIterative(Node node)
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

            while (node != null || s.Any())
            {
                if (node != null)
                {
                    s.Push(node);
                    node = node.LeftChild;
                }
                else
                {
                    node = s.Pop();

                    if(node.Data < 0)
                    {
                        Console.WriteLine(node.Data * (-1));
                        node = null;
                    }
                    else
                    {
                        var rightChild = node.RightChild;

                        node.Data = node.Data * (-1);
                        s.Push(node);

                        node = rightChild;
                    }
                }
            }

            #endregion
        }
    }
}
