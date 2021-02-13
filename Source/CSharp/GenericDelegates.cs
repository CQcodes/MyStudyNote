using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public delegate int NormalDelegate(int a, int b);
    public static class GenericDelegates
    {
        public static int Multiply(int a, int b) => a * b;
        public static void GenericDelegateDemo()
        {
            var oldSchoolDelegate = new NormalDelegate(GenericDelegates.Multiply);
            oldSchoolDelegate.Invoke(5, 6);
            oldSchoolDelegate(3, 4);

            var oldSchoolDelegateWithAnonymousMethod = new NormalDelegate(delegate (int a, int b) { return a * b; });
            oldSchoolDelegateWithAnonymousMethod(7, 8);

            var delegateWithLambdaExpression = new NormalDelegate((a,b)=>a*b);
            //var delegateWithDirectLambdaExpression = (a, b) => a * b; Can not assign lambda expression to implicitly typed variable
            // Can be assigned to Generic Delegates.

            // takes input parameter and returns value
            Func<int, int, int> sumFunc = (a, b) => a+b;

            // takes only input params. No output.
            Action<int, int> sumPrintAction = (a, b) => { Console.WriteLine($"from sumPrintAction : { a + b}"); };
            
            // takes one input and returns boolean
            Predicate<int> isEvenPredicate = n => n % 2 == 0;

            var sum = sumFunc(5, 6);
            Console.WriteLine($"sumFunc result : {sum}");

            sumPrintAction(7, 8);

            var n = 9;
            Console.WriteLine($"Is Number({n}) even : {(isEvenPredicate(n) ? "YES" : "NO")} .");
        }
    }
}
