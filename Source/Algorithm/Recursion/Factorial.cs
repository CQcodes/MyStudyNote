using System;

namespace Algorithm.Recursion
{
    public class Factorial : IAlgorithm
    {
        public void Execute()
        {
            int n = 1;
            Console.WriteLine($"RECURSION : factorial of '{n}' = {FactorialRecursive(n)}");
            Console.WriteLine($"ITERATION : factorial of '{n}' = {FactorialIterative(n)}");
        }

        private int FactorialRecursive(int n)
        {
            if(n > 0)
            {
                return n * FactorialRecursive(n - 1);
            }
            return 1;
        }

        private int FactorialIterative(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
                f = f * i;
            return f;
        }
    }
}
