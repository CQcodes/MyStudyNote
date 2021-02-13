using System;

namespace ProgramPractice
{
    /*
     * Given an integer N, the task is to print first Nth pure numbers. A number is said to be pure if

       It has even number of digits.
       All the digits are either 4 or 5.
       And the number is a palindrome.
       First few pure numbers are 44, 55, 4444, 4554, 5445, 5555, …

       Examples:
       Input: N = 4
       Output: 44 55 4444 5445
       
       Input: N = 10
       Output: 44 55 4444 4554 5445 5555 444444 454454 544445 554455
     */
    public class PureNumbers
    {
        public string PrintPureNumber(int N)
        {
            throw new NotImplementedException();
        }

        public static void Execute()
        {
            PureNumbers pureNumbers = new PureNumbers();

            var position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pureNumbers.PrintPureNumber(position));
            Console.ReadLine();
        }
    }
}
