using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinkedList
{
    public class LinkedListDemo : IDataStructure
    {
        public void Execute()
        {
            var head = new Node(1);
            head.Next = new Node(2);
            head.Next.Next = new Node(3);

            Print(head);
        }

        private void Print(Node node)
        {
            while(node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }
    }

    public class Node
    {
        private int _data;
        public Node(int d)
        {
            _data = d;
        }

        public int Data
        {
            get { return _data; }
            //set { _data = value; }
        }

        public Node Next { get; set; }
    }
}
