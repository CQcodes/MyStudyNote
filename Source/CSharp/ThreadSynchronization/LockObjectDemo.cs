using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace CSharp.ThreadSynchronization
{
    /// <summary>
    /// Both Monitor class and Lock class provides a mechanism to synchronise access to objects
    /// Lock is shortcut  Monitor.Enter in Try and Monitor.Exit in Finally
    /// </summary>
    public class LockObjectDemo
    {
        private object _lock = new object();
        public void Execute()
        {
            //ThreadDemo();
            TaskDemo();
        }

        #region lock demo using threads

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
            lock (_lock)
            {
                Console.Write("Welcome to the ");
                Thread.Sleep(500);
                Console.WriteLine("Jungle of Jumanji");
            }
        }

        #endregion

        #region lock demo using task

        private void TaskDemo()
        {
            var tasks = new List<Task>();
            tasks.Add(PrintGreetingMessageAsync());
            tasks.Add(PrintGreetingMessageAsync());
            tasks.Add(PrintGreetingMessageAsync());
            tasks.Add(PrintGreetingMessageAsync());
            Task.WhenAll(tasks).GetAwaiter().GetResult();// bad practice (not recommended) => Use async-await 

            Console.WriteLine();
        }
        private async Task PrintGreetingMessageAsync()
        {
            lock (_lock)
            {
                Console.Write("Welcome to the ");
                Task.Delay(500);
                Console.WriteLine("Jungle of Jumanji");
            }

            //Console.Write("Welcome to the ");
            //await Task.Delay(500);
            //Console.WriteLine("Jungle of Jumanji");
        }

        #endregion

    }
}
