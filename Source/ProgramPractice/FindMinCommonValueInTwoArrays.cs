using System;
using System.Collections;

namespace ProgramPractice
{
    public class FindMinCommonValueInTwoArrays
    {
        public void Execute()
        {
            var arr1 = new int[] { 1,2,5,-8,9,10,7};
            var arr2 = new int[] { 10, 8, 7, 9, 2 };
            FindMinimumCommonValue(arr1, arr2);
        }

        private void FindMinimumCommonValue(int[] a1, int[] a2)
        {
            var minComm =int.MaxValue;
            var ht = new Hashtable();
            for(int i=0; i< a1.Length; i++)
            {
                ht.Add(a1[i], 1);
            }

            for(int i =0; i< a2.Length; i++)
            {
                if(a2[i] < minComm && ht.ContainsKey(a2[i]))
                {
                    minComm = a2[i];
                }
            }

            Console.WriteLine($"minimum common value : {minComm}");
        }
    }
}
