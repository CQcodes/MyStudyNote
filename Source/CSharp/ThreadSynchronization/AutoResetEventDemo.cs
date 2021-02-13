using System;
using System.Collections.Generic;
using System.Threading;

namespace CSharp.ThreadSynchronization
{
    /// <summary>
    /// AutoResetEvent => Means the Signal is automatically reset as soon as a thread starts executing.
    /// WaitOne() will block all the thread and wait for the Signal to be Set()
    /// When Signal is Set() then Only one Thread starts executing and immediately the Signal is auto Reset()
    /// So the rest of the threads keep waiting at WaitOne()
    /// One by One
    /// </summary>
    public class AutoResetEventDemo
    {
        private List<string> _data = new List<string>();
        private AutoResetEvent _autoResetEvent = new AutoResetEvent(false);
        public void Execute()
        {
            new Thread(Write).Start();
            for (int i = 0; i < 3; i++)
            {
                new Thread(Read).Start();
            }

            // NOTE : ARE can be set like this from un-synchronized code block which goof up the entire execution flow.
            // Ideally, we should not Set()/Reset() the WaitHandle from outside of the synchronized code block
            // MUTEX helps here, it does not allow to SET/RESET from un-synchronized code block, it throws run-time exception
            // Thread.Sleep(6500);
            //_autoResetEvent.Set();
        }

        private void Write()
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} has started writing.");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}- writting ... ... ...");
                _data.Add($"{i} - write");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} has finished writing.");
            _autoResetEvent.Set();
        }

        private void Read()
        {
            Console.WriteLine($"Wait for ARE signal");
            _autoResetEvent.WaitOne();
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Started Reading...");
            Thread.Sleep(500);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} reading => {string.Join(',', _data)}");
            Thread.Sleep(500);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Completed Reading...");
            _autoResetEvent.Set();
        }
    }
}
