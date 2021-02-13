using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPractice
{
    public class FindGreatestPrimeDivisor
    {
        private static int GreatestPrimeDivisor(int n)
        {
            int max = -1;

            // divide it 2 all the way down
            while(n%2 == 0)
            {
                max = 2;
                n /= 2;
            }

            // now n is odd
            // start with odd and increment by 2(skip even numbers)
            for(int i = 3; i <= Math.Sqrt(n); i+=2)
            {
                while(n%i==0)
                {
                    max = i;
                    n /= i;
                }
            }

            // This condition is to handle 
            // the case when n is a prime 
            // number greater than 2 
            if (n > 2)
                max = n;

            return max;
        }
        public static void Execute()
        {
            Console.WriteLine("Find the Greatest prime factor of the given number :");
            Console.WriteLine("Enter start number : ");
            int s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GreatestPrimeDivisor(s));
            Console.ReadLine();
        }
    }
}
