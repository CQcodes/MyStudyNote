using System;
using System.Threading;
using System.Collections.Generic;

namespace CSharp.ThreadSynchronization
{
    /// <summary>
    /// ManualResetEvent class is useful when one thread is doing some work and we want all other threads to wait until
    /// the first thread finish its work. When signal is Set() Then all other threads execute at same time. 
    /// 
    /// But in case of AutoResetEvent class,
    /// all threads will be waiting on WaitOne(). When Signal is Set(), then only one thread will proceed and execute. 
    /// all thread will finish executing like this one-by-one.
    /// </summary>
    public class ManualResetEventDemo
    {
        private List<string> _data = new List<string>();
        private ManualResetEvent _manualResetEvent = new ManualResetEvent(false);
        public void Execute()
        {
            new Thread(Write).Start();
            for (int i = 0; i < 3; i++)
            {
                new Thread(Read).Start();
            }
        }

        private void Write()
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} has started writing.");
            _manualResetEvent.Reset();// Reset MRE Signal
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}- writting ... ... ...");
                _data.Add($"{i} - write");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} has finished writing.");
            _manualResetEvent.Set();// Set MRE Signal
        }

        private void Read()
        {
            Console.WriteLine($"Wait for MRE signal");
            _manualResetEvent.WaitOne();// Wait
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Started Reading...");
            Thread.Sleep(500);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} reading => {string.Join(',',_data)}");
            Thread.Sleep(500);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Completed Reading...");
        }
    }
}
