using System;
using System.Threading;

namespace CSharp
{
    public class ThreadPractice
    {
        //passing data to thread and recieving from it
        //public delegate void ThreadStart()
        //public delegate void ParameterizedThreadStart(object inputParam)
        //constructor pass input params to class object 
        // callback function to return data , can be passed as an constructor param
        public static void PerformThreadPractice()
        {
            var o = new DummyClass(20);
            Thread thread = new Thread(() => o.PrintNumbers(5));
            thread.Start();
        }
    }

    public class DummyClass
    {
        private int number;
        public DummyClass(int targetNumber)
        {
            number = targetNumber;
        }
        public void PrintNumbers()
        {
            PrintNumbers(number);
        }
        public void PrintNumbers(int targetNumber)
        {
            for (int i = 1; i <= targetNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
