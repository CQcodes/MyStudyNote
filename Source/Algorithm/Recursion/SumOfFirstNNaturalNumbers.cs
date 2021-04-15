using System;

namespace Algorithm.Recursion
{
    public class SumOfFirstNNaturalNumbers : IAlgorithm
    {
        public void Execute()
        {
            int n = 50;
            Console.WriteLine($"RECURSION : Sum of natural numbers upto '{n}' = {SumOfNaturalNumbers(n)}");
            Console.WriteLine($"ITERATION : Sum of natural numbers upto '{n}' = {SumOfNaturalNumbersIterative(n)}");
        }

        private int SumOfNaturalNumbers(int n)
        {
            if(n>0)
            {
                return n + SumOfNaturalNumbers(n - 1);
            }
            return 0;
        }

        private int SumOfNaturalNumbersIterative(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += i;
            return sum;
        }
    }
}
