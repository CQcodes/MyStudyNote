using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.ArrayManipulation
{
    public class ReverseArray : IAlgorithm
    {
        public void Execute()
        {
            var a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 13, 15 };
            Console.WriteLine($"Original Array : {string.Join(',', a)}");
            Reverse(a);
            Console.WriteLine($"Reversed Array : {string.Join(',', a)}");
        }

        private void Reverse(int[] a)
        {
            for(int i =0, j = a.Length-1; i< j; i++,j--)
            {
                //swap
                var t = a[i];
                a[i] = a[j];
                a[j] = t;
            }
        }
    }
}
