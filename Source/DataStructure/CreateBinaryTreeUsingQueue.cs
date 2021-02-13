using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure
{
    public partial class BinaryTree
    {
        public Node CreateBinaryTree(int root)
        {
            // Initialize queue
            var q = new Queue<Node>();

            // Create root node
            var rootNode = new Node(root);

            // Enqueue root node into the queue
            q.Enqueue(rootNode);

            while(q.Any())
            {
                var currentNode = q.Dequeue();

                Console.WriteLine($"Enter Left child for Node({currentNode.Data}) : ");
                var leftChildData = Convert.ToInt32(Console.ReadLine());
                if(leftChildData>-1)
                {
                    // create left child
                    var leftChild = new Node(leftChildData);

                    // assign the new left child to currentNode
                    currentNode.LeftChild = leftChild;

                    // enter new child into the queue
                    q.Enqueue(leftChild);
                }
                Console.WriteLine("Left child entered successfully.");

                Console.WriteLine($"Enter right child for Node({currentNode.Data}) : ");
                var rightChildData = Convert.ToInt32(Console.ReadLine());
                if (rightChildData > -1)
                {
                    // create right child
                    var rightChild = new Node(rightChildData);

                    // assign the new right child to currentNode
                    currentNode.RightChild = rightChild;

                    // enter new child into the queue
                    q.Enqueue(rightChild);
                }
                Console.WriteLine("Right child entered successfully.");
            }

            Console.WriteLine("Tree creation complete.");
            return rootNode;
        }
    }
}
