using System;

namespace Algorithm.Recursion
{
    public class PowerFunction : IAlgorithm
    {
        public void Execute()
        {
            int m = 2;
            int n = 5;
            Console.WriteLine($"RECURSION : Raising '{m}' to the power '{n}' = {PowerRecursive(m, n)}");
            Console.WriteLine($"ITERATION : Raising '{m}' to the power '{n}' = {PowerIterative(m, n)}");
        }

        private int PowerRecursive(int m, int n)
        {
            if (n > 0)
            {
                return m * PowerRecursive(m,n - 1);
            }
            return 1;
        }

        private int PowerIterative(int m,int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
                f = f * m;
            return f;
        }
    }
}
