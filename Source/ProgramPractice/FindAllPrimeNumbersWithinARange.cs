using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPractice
{
    public class FindAllPrimeNumbersWithinARange
    {
        private static void FindAllPrimeNumbers(int start,int end)
        {
            for(int i = start; i<= end; i++)
            {
                int flag = 0;

                // check if prime number
                for(int j = 2; j<= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0 && i != 1)
                    Console.WriteLine(i);
            }
        }

        public static void Execute()
        {
            Console.WriteLine("Find the prime numbers within a range of numbers :");
            Console.WriteLine("Enter start number : ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter end number : ");
            int e = Convert.ToInt32(Console.ReadLine());

            FindAllPrimeNumbers(s, e);
            Console.ReadLine();
        }
    }
}
