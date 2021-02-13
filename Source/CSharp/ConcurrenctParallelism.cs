using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp
{
    public class ConcurrenctParallelism
    {
        private void Download()
        {
            //Task.Factory.StartNew(DownloadFile1Async);
            //Task.Factory.StartNew(DownloadFile2Async);
            DownloadFile1Async();
            DownloadFile2Async();
            HelloMessage();
        }

        private void HelloMessage()
        {
            Console.WriteLine("Please enter your name.");
            string message = Console.ReadLine();
            Console.WriteLine("Hello " + message);
            Console.ReadLine();
        }

        private async Task DownloadFile1Async()
        {
            Console.WriteLine("Downloading File-1 ....");
            await Task.Delay(10000);
            Console.WriteLine("File-1 downloaded.");
        }

        private async Task DownloadFile2Async()
        {
            Console.WriteLine("Downloading File-2 ....");
            await Task.Delay(10000);
            Console.WriteLine("File-2 downloaded.");
        }

        public static void Execute()
        {
            ConcurrenctParallelism concurrenctParallelism = new ConcurrenctParallelism();
            concurrenctParallelism.Download();
        }
    }
}
