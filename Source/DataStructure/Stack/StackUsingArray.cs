using System;

namespace DataStructure.Stack
{
    public class StackUsingArrayDemo : IDataStructure
    {
        public void Execute()
        {
            var s = new StackUsingArray(5);
            s.Push(5);
            s.Push(3);
            s.Push(1);
            s.Push(5);
            s.Push(3);
            Console.WriteLine($"top - {s.Top()}");
            while (!s.IsEmpty())
            {
                Console.WriteLine($"deleted - {s.Pop()}");
            }
            Console.WriteLine($"Is Stack empty : {s.IsEmpty()}");
        }
    }
    public class StackUsingArray
    {
        private int[] a;
        private int top = -1;
        private int size;

        public StackUsingArray(int s)
        {
            size = s;
            a = new int[size];
        }

        public int Top()
        {
            return a[top];
        }

        public void Push(int data)
        {
            if(top < size-1)
                a[++top] = data;
            else
                throw new StackOverflowException();
        }

        public int Pop()
        {
            if (top < 0)
                throw new InvalidOperationException("Stack is empty.");

            return a[top--];
        }

        public bool IsEmpty()
        {
            return top < 0;
        }
    }
}
