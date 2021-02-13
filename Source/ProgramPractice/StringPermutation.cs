using System;

namespace ProgramPractice
{
    class StringPermutation
    {
        private void Print(string[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        private static String swap(String a,int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }

        /// <summary>
        /// input : "ABC"
        /// output : all possible permutaion of the string i.e. ABC, ACB, BAC, BCA, CAB, CBA
        /// </summary>
        /// <param name="input"></param>
        public void Permute(string input,int l,int r)
        {
            if(l == r)
            {
                Console.WriteLine(input);
            }
            for(int i = l; i <= r; i++)
            {
                input = swap(input, l, i);
                Permute(input, l + 1, r);
                input = swap(input, l, i);
            }
        }

        public static void Execute()
        {
            StringPermutation o = new StringPermutation();
            string input = "ABC";
            o.Permute(input, 0, input.Length - 1);
            Console.ReadLine();
        }
    }
}
