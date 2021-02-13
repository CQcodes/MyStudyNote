using System;
using System.Threading;

namespace CSharp.ThreadSynchronization
{
    /// <summary>
    /// Both Monitor class and Lock class provides a mechanism to synchronise access to objects
    /// Lock is shortcut  Monitor.Enter in Try and Monitor.Exit in Finally
    /// </summary>
    public class MonitorDemo
    {
        private object _lock = new object();
        public void Execute()
        {
            ThreadDemo();
        }

        private void ThreadDemo()
        {
            Thread t1 = new Thread(PrintGreetingMessage);
            Thread t2 = new Thread(PrintGreetingMessage);
            Thread t3 = new Thread(PrintGreetingMessage);

            t1.Start(); t2.Start(); t3.Start();

            Console.ReadLine();
        }

        private void PrintGreetingMessage()
        {
            Monitor.Enter(_lock);
            try
            {
                Console.Write("Welcome to the ");
                Thread.Sleep(500);
                Console.WriteLine("Jungle of Jumanji");
            }
            finally
            {
                Monitor.Exit(_lock);
            }
        }
    }
}
