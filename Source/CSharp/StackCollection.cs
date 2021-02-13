using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp
{
    public class StackCollection
    {
        public static void Execute()
        {
            Stack s = new Stack();
            s.Push("");
            s.Push(1);
            s.Push(true);

            Console.WriteLine("non-generic stack");
            foreach (object o in s)
            {
                Console.WriteLine(o);
            }

            Stack<int> s1 = new Stack<int>();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);

            Console.WriteLine("generic stack");
            foreach (int o in s1)
            {
                Console.WriteLine(o);
            }

            Console.ReadLine();
        }
    }
}
