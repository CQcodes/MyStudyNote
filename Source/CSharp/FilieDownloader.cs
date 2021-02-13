using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp
{
    public static class FilieDownloader
    {
        public async static Task PerformFileDownloadAsync()
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            Console.WriteLine($"Requesting File-1 download. on Thread - {Thread.CurrentThread.ManagedThreadId}, IsBGT : {Thread.CurrentThread.IsBackground}, isTPL : {Thread.CurrentThread.IsThreadPoolThread}");
            var downloadingFile1 = DownloadFileAsync("File-1");

            Console.WriteLine($"Requesting File-2 download. on Thread - {Thread.CurrentThread.ManagedThreadId}, IsBGT : {Thread.CurrentThread.IsBackground}, isTPL : {Thread.CurrentThread.IsThreadPoolThread}");
            var downloadingFile2 = DownloadFileAsync("File-2");

            await Task.WhenAll(downloadingFile1, downloadingFile2);

            sw.Stop();
            Console.WriteLine($"All File downloads completed. on Thread - {Thread.CurrentThread.ManagedThreadId}, IsBGT : {Thread.CurrentThread.IsBackground}, isTPL : {Thread.CurrentThread.IsThreadPoolThread}");
            Console.WriteLine($"File downloading using async took - {sw.ElapsedMilliseconds} ms");
        }

        public async static Task DownloadFileAsync(string fileName)
        {
            Console.WriteLine($"File ({fileName}) started downloading. on Thread - {Thread.CurrentThread.ManagedThreadId}, IsBGT : {Thread.CurrentThread.IsBackground}, isTPL : {Thread.CurrentThread.IsThreadPoolThread}");
            await Task.Run(()=>
            { 
                for(int i=0;i<10;i++)
                {
                    Console.WriteLine($"{fileName} downloading ... ... ... on Thread - {Thread.CurrentThread.ManagedThreadId}, IsBGT : {Thread.CurrentThread.IsBackground}, isTPL : {Thread.CurrentThread.IsThreadPoolThread}");
                    Thread.Sleep(500);
                }
            });
            Console.WriteLine($"File ({fileName}) download has been completed. on Thread - {Thread.CurrentThread.ManagedThreadId}, IsBGT : {Thread.CurrentThread.IsBackground}, isTPL : {Thread.CurrentThread.IsThreadPoolThread}");
        }

        public static void PerformFileDownloadUsingThreads()
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            Console.WriteLine($"Requesting File-1 download. on Thread - {Thread.CurrentThread.ManagedThreadId}");
            Thread t1 = new Thread(delegate() { DownloadFile("File-1"); });

            Console.WriteLine($"Requesting File-2 download. on Thread - {Thread.CurrentThread.ManagedThreadId}");
            Thread t2 = new Thread(delegate () { DownloadFile("File-1"); });

            t1.Start();t2.Start();
            t1.Join();t2.Join();

            sw.Stop();
            Console.WriteLine($"All File downloads completed. on Thread - {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"File downloading using threads took - {sw.ElapsedMilliseconds} ms");
        }

        public static void DownloadFile(string fileName)
        {
            Console.WriteLine($"File ({fileName}) started downloading. on Thread - {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{fileName} downloading ... ... ... on Thread - {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(500);
            }
            Console.WriteLine($"File ({fileName}) download has been completed.");
        }
    }
}
