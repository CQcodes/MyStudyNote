using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Recursion
{
    /// <summary>
    /// TaylorSeries(x,n) = (x^0/0!) + (x^1/1!) + (x^2/2!) + (x^3/3!) + .... + (x^n)/n!
    /// by Horner's rule T(x,n) = 1 + x/1 * [1 + x/2 * [1 + x/3 * [1 + x/4 * ...[1 + x/n] ] ] ]
    /// </summary>
    public class TaylorSeries : IAlgorithm
    {
        private static double p = 1;
        private static double f = 1;
        private static double hornerResult = 1;
        public void Execute()
        {
            int x = 4;
            int n = 15;
            Console.WriteLine($"RECURSION : Taylor Series (x={x},n={n}) = {TaylorSeriesRecursive(x, n)}");
            Console.WriteLine($"ITERATION : Taylor Series (x={x},n={n}) = {TaylorSeriesIterative(x, n)}");
            Console.WriteLine($"RECURSION : Taylor Series using Horner's rule (x={x},n={n}) = {TaylorSeriesUsingHornerRuleRecursive(x, n)}");
            Console.WriteLine($"ITERATION : Taylor Series using Horner's rule (x={x},n={n}) = {TaylorSeriesUsingHornerRuleIterative(x, n)}");
        }

        private double TaylorSeriesRecursive(int x, int n)
        {
            if(n>0)
            {
                double t = TaylorSeriesRecursive(x, n-1);
                p = p * x;
                f = f * n;
                return t + (p / f);
            }
            return 1;
        }

        private double TaylorSeriesIterative(int x, int n)
        {
            double _p = 1;
            double _f = 1;
            double _t = 1;
            for (int i = 1; i < n; i++)
            {
                _p = _p * x;
                _f = _f * i;
                _t = _t + (_p / _f);
            }
            return _t;
        }

        private double TaylorSeriesUsingHornerRuleRecursive(int x, int n)
        {
            if (n > 0)
            {

                hornerResult = 1 + (x/(double)n) * hornerResult;
                return TaylorSeriesUsingHornerRuleRecursive(x, n-1);
            }
            return hornerResult;
        }

        private double TaylorSeriesUsingHornerRuleIterative(int x, int n)
        {
            double _t = 1;
            for (double i = n; i > 0; i--)
            {
                _t = 1 + (x / i) * _t;
            }
            return _t;
        }
    }
}
