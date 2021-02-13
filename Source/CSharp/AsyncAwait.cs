using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp
{
    public class AsyncAwait
    {
        public void Start()
        {
            
        }
        private async Task PrintAsync(int num)
        {
            var stopWatch = System.Diagnostics.Stopwatch.StartNew();
            List<Task<string>> tasks = new List<Task<string>>();
            for (int i = 0; i < num; i++)
            {
                tasks.Add(PrintManager(i));
            }

            var result = await Task.WhenAll(tasks.ToArray());
            stopWatch.Stop();
            foreach (var item in result)
            {
                Console.WriteLine(item + Environment.NewLine);
            }
            Console.WriteLine("Elapsed time : " +  stopWatch.ElapsedMilliseconds);
        }

        private async Task Print(int num)
        {
            var stopWatch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < num; i++)
            {
                string s = await PrintManager(i);
                Console.WriteLine(s + Environment.NewLine);
            }
            stopWatch.Stop();
            Console.WriteLine("Elapsed time : " + stopWatch.ElapsedMilliseconds);
        }

        private async Task<string> PrintManager(int i)
        {
            string p = await PrintEngine(i);
            return p;
        }

        private async Task<string> PrintEngine(int index)
        {
            Task<string> p = Task.Run(() => PrintRepo(index));
            string k = await p;
            return k;
        }

        private string PrintRepo(int index)
        {
            Thread.Sleep(2500);
            List<string> sl = new List<string>()
            {
                "string1",
                "string2",
                "string3",
                "string4",
                "string5",
                "string6",
            };

            return sl[index];
        }

        public static async void Execute(string[] args)
        {
            AsyncAwait asyncAwait = new AsyncAwait();
            await asyncAwait.PrintAsync(6);
            //Print(6);
            Console.ReadLine();
        }
    }
}
