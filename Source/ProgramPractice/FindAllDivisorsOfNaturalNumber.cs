using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPractice
{
    public class FindAllDivisorsOfNaturalNumber
    {
        /// <summary>
        /// time complexity : O(sqrt(n))
        /// Space complexity : O(1)
        /// </summary>
        /// <param name="n"></param>
        private static void FindAllDivisors(int n)
        {
            //this is to print the divisors in order
            int[] arr = new int[n];
            int d = 0;
            //----

            for(int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    int a = n / i;
                    if(a == i)
                        Console.WriteLine(i);
                    else
                    {
                        Console.WriteLine(i);
                        //Console.WriteLine(a);

                        //instead of printing it. Store it in the array.
                        arr[d] = a;
                        d++;
                    }
                }
            }

            //now print the stored divisors backwards from the array 
            for (int j = d - 1; j >= 0; j--)
                Console.WriteLine(arr[j]);
            //----
        }

        public static void Execute()
        {
            Console.WriteLine("Find all divisors of natural number :  ");

            Console.WriteLine("Enter a natural number ");
            int n = Convert.ToInt32(Console.ReadLine());

            FindAllDivisors(n);

            Console.ReadLine();
        }
    }
}
