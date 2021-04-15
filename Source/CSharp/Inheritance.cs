using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class Parent
    {
        static Parent()
        {
            Console.WriteLine("Parent Static Constructor.");
        }
        public Parent()
        {
            Console.WriteLine("Parent Default Constructor.");
        }

        public virtual void Print()
        {
            Console.WriteLine("Parent : Print");
        }
    }

    public class Child : Parent
    {
        static Child()
        {
            Console.WriteLine("Child Static Constructor.");
        }

        public Child()
        {
            Console.WriteLine("Child Default Constructor.");
        }

        public override void Print()
        {
            Console.WriteLine("Child : Print");
        }
    }

    public class InheritanceDemo
    {
        public void Execute()
        {
            Parent pc = new Child();
            pc.Print();

            //Console.WriteLine("-----------------------------");

            //Child cc = new Child();
            //cc.Print();

            //Console.WriteLine("-----------------------------");

            //Parent pp = new Parent();
            //pp.Print();
        }
    }
}
