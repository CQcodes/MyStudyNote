using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class PrivateAndStaticConstructor
    {
        public static void Execute()
        {
            A.Method();
            A a = new A();
            Console.ReadLine();
        }
    }

    public class A
    {
        static string s = "staic";
        int x;
        public A()
        {
            Console.WriteLine("Hello from public constructor of A." + x);
        }

        static A()
        {
            Console.WriteLine("Hello from static constructor of A." + s);
        }

        public static void Method()
        {
            Console.WriteLine("Hello from public method of A.");
        }
    }
}
