using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent");
        }

        public virtual void Print()
        {
            Console.WriteLine("Parent : Print");
        }
    }

    public class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Child");
        }

        public override sealed void Print()
        {
            Console.WriteLine("Child : Print");
        }
    }
}
