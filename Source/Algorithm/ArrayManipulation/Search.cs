using System;

namespace Algorithm.ArrayManipulation
{
    /// <summary>
    /// Liner Search : 
    ///     -Key should be unique, if not, first occurance will be returned
    ///     -Scan the array linearly one by one
    /// Binary Search : 
    ///     Array must be sorted
    ///     find mid = (low + high) / 2
    /// </summary>
    public class Search : IAlgorithm
    {
        public void Execute()
        {
            var a = new int[] { 1, 2, 3 ,4, 5, 6, 7, 8,9,11,13,15 };
            int key = 13;
            Console.WriteLine(string.Join(',',a));
            Console.WriteLine($"Iterative Binary Search : Index of '{key}' in the above array is : {BinarySearch(a,key)}");
            Console.WriteLine($"Recursive Binary Search : Index of '{key}' in the above array is : {RBinarySearch(a, key, a.Length-1, 0)}");
        }

        private int BinarySearch(int[] a, int key)
        {
            int l = 0;
            int h = a.Length-1;
            int m;

            while(l<=h)
            {
                m = (l + h) / 2;

                if (key == a[m])
                    return m;
                else if(key < a[m])
                    h = m - 1;
                else
                    l = m + 1;
            }
            return -1;
        }

        private int RBinarySearch(int[] a, int key, int h, int l)
        {
            while (l <= h)
            {
                int m = (l + h) / 2;

                if (key == a[m])
                    return m;
                else if (key < a[m])
                    return RBinarySearch(a,key,m-1,l);
                else
                    return RBinarySearch(a, key, h, m+1);
            }
            return -1;
        }
    }
}
