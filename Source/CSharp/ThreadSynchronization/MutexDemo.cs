using System;
using System.Collections.Generic;
using System.Threading;

namespace CSharp.ThreadSynchronization
{
    public class MutexDemo
    {
        // NOTE : ARE can be set like this from un-synchronized code block which goof up the entire execution flow.
        // Ideally, we should not Set()/Reset() the WaitHandle from outside of the synchronized code block
        // MUTEX helps here, it does not allow to SET/RESET from un-synchronized code block, it throws run-time exception

        private List<string> _data = new List<string>();
        private Mutex _mutex = new Mutex();
        public void Execute()
        {
            new Thread(Write).Start();
            for (int i = 0; i < 3; i++)
            {
                new Thread(Read).Start();
            }

            //Thread.Sleep(6500);
            //_mutex.ReleaseMutex();
        }

        private void Write()
        {
            if(_mutex.WaitOne())
            {
                try
                {
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} has started writing.");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"{i}- writting ... ... ...");
                        _data.Add($"{i} - write");
                        Thread.Sleep(1000);
                    }
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} has finished writing.");
                }
                finally
                {
                    _mutex.ReleaseMutex();
                }
            }
            
        }

        private void Read()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} : Wait for Mutex signal");
            if(_mutex.WaitOne())
            {
                try
                {
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} : Started Reading...");
                    Thread.Sleep(500);
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} : reading => {string.Join(',', _data)}");
                    Thread.Sleep(500);
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} : Completed Reading...");
                }
                finally
                {
                    _mutex.ReleaseMutex();
                }
            }
        }
    }
}
