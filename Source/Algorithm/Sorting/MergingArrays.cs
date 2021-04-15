using System;

namespace Algorithm.Sorting
{
    public class MergingArrays
    {
        public void Execute()
        {
            var a = new int[] { 1, 3, 5, 7, 9 };
            var b = new int[] { 2, 4, 6, 8, 10, 12, 14, 16 };
            var result = MergeTwoSortedArrays(a, b);
            Console.WriteLine(string.Join(',',result));
        }

        // 2-way merge / 4-way merge / m-way merge
        private int[] MergeTwoSortedArrays(int[] a,int[] b)
        {
            var c = new int[a.Length+b.Length];
            int k = 0; int i = 0; int j = 0;

            while(i < a.Length && j < b.Length)
            {
                if (a[i] <= b[j])
                    c[k++] = a[i++];
                else
                    c[k++] = b[j++];
            }

            while(i < a.Length)
                c[k++] = a[i++];

            while (j < b.Length)
                c[k++] = b[j++];

            return c;
        }
    }
}
