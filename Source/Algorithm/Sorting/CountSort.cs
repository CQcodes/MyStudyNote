using System;

namespace Algorithm.Sorting
{
    public class CountSort : IAlgorithm
    {
        public void Execute()
        {
            var a = new int[] { 5, 8, 7, 6, 3, 4, 9, 5, 1, 2, 9, 4 };
            Console.WriteLine(string.Join(',',Sort(a)));
        }

        private int FindMax(int[] a)
        {
            int max = int.MinValue;
            foreach(int i in a)
            {
                if(max < i)
                {
                    max = i;
                }
            }
            return max;
        }

        private int[] Sort(int[] a)
        {
            var c = new int[FindMax(a)+1];
            foreach (int n in a)
            {
                c[n]++;
            }

            int k = 0; int i = 0;
            while(k<c.Length)
            {
                while(c[k] > 0)
                {
                    a[i++] = k;
                    c[k]--;
                }
                k++;
            }
            return a;
        }
    }
}
