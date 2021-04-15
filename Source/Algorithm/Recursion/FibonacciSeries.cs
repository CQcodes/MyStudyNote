using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Recursion
{
    /// <summary>
    /// 0 1 1 2 3 5 8 13 21 34.. nth term
    /// </summary>
    public class FibonacciSeries : IAlgorithm
    {
        public void Execute()
        {
            int n = 9;
            Console.WriteLine($"{n} th term in fibanacci series : {FibonacciSeriesFindNthTermRecursive(n)}");
            Console.WriteLine($"No Duplicate calculations : {n} th term in fibanacci series : {FibonnaciSeriesFindNthTermIterative(n)}");
            Console.WriteLine($"Mempry efficient : {n} th term in fibanacci series : {FibonnaciSeriesFindNthTerm(n)}");
        }

        // duplicate work
        private int FibonacciSeriesFindNthTermRecursive(int n)
        {
            if (n <= 1)
                return n;

            return FibonacciSeriesFindNthTermRecursive(n - 2) + FibonacciSeriesFindNthTermRecursive(n - 1);
        }

        //save the calculated value
        private int FibonnaciSeriesFindNthTermIterative(int n)
        {
            var f = new int[n + 1];

            f[0] = 0;
            f[1] = 1;

            for(int i = 2; i<= n; i++)
            {
                f[i] = f[i - 2] + f[i - 1];
            }

            return f[n];
        }

        // memeory efficient
        private int FibonnaciSeriesFindNthTerm(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }
    }
}
