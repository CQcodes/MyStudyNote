using System;

namespace ProgramPractice
{
    class PrintNumberRange
    {
        /// <summary>
        /// input : 1,2,3-6,9,5
        /// output : 1,2,3,4,5,6,9,5
        /// </summary>
        public void PrintArrayWithNumberRange()
        {
            //variable declaration
            string input, output;

            //reading input from the console
            Console.WriteLine("enter input value :");
            input = Console.ReadLine();
            output = string.Empty;

            //splitting the input string by ','
            string[] splits = input.Split(',');

            foreach (string s in splits)
            {
                if (s.Contains("-"))
                {
                    //if element contains '-' , then it is a number range
                    //now we have findout the lower limit & upper limit of the number range
                    //splitting the element again by '-'
                    //element at [0] is lower limit & element at [1] is upper limit
                    int ll = 0, ul = 0;
                    ll = int.Parse(s.Split('-')[0]);
                    ul = int.Parse(s.Split('-')[1]);

                    //printing the number range
                    for (int i = ll; i <= ul; i++)
                    {
                        output = output + i.ToString() + ",";
                    }
                }
                else
                {
                    output = output + s + ",";
                }
            }

            Console.WriteLine("Output : " + output);
            Console.ReadLine();
        }

        public static void Execute()
        {
            PrintNumberRange o = new PrintNumberRange();
            o.PrintArrayWithNumberRange();
        }
    }
}
