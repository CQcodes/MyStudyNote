using System;
using System.Collections.Generic;
using System.Collections;

namespace CSharp
{
    public class QueueCollection
    {
        public static void Execute()
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue("2");
            q.Enqueue(3);

            Console.WriteLine("non-generic queue");
            foreach (object o in q)
            {
                Console.WriteLine(o);
            }

            Queue<int> q1 = new Queue<int>();
            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue(3);

            Console.WriteLine("generic queue");
            foreach (object o in q1)
            {
                Console.WriteLine(o);
            }

            Console.ReadLine();
        }
    }
}
