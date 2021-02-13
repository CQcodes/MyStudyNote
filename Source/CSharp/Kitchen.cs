using System;
using System.Threading.Tasks;
using System.Threading;

namespace CSharp
{
    public class Kitchen
    {
        public async Task MakeTeaAsync()
        {
            Console.WriteLine($"Making Tea Process has started . On Thread - {Thread.CurrentThread.ManagedThreadId} .");

            var boilingWaterTask = BoilWaterAsync();
            //var boilingWaterTask = Task.Run(() => BoilWater());
            //BoilWater();

            Console.WriteLine($"Take a clean Cup. On Thread - {Thread.CurrentThread.ManagedThreadId} .");
            Thread.Sleep(2000);
            Console.WriteLine($"Take a tea-bag. On Thread - {Thread.CurrentThread.ManagedThreadId} .");
            Thread.Sleep(2000);
            Console.WriteLine($"Put Tea-bag in the Cup. On Thread - {Thread.CurrentThread.ManagedThreadId} .");


            Console.WriteLine($"Wait for boil water task. On Thread - {Thread.CurrentThread.ManagedThreadId} .");
            var water = await boilingWaterTask;

            Console.WriteLine($"Pour boiling {water} into the Cup. On Thread - {Thread.CurrentThread.ManagedThreadId} .");
            Thread.Sleep(1000);

            Console.WriteLine($"Tea is ready ! On Thread - {Thread.CurrentThread.ManagedThreadId} .");
        }

        private async Task<string> BoilWaterAsync()
        {
            Console.WriteLine($"Boiling Water started. On Thread - {Thread.CurrentThread.ManagedThreadId} .");
            Console.WriteLine($"Boiling... Boiling... Boiling... On Thread - {Thread.CurrentThread.ManagedThreadId} .");
            await Task.Delay(1000);
            for(int i = 0; i<4; i++)
            {
                Console.WriteLine($"Printing from for loop. Iteration : {1+i}. on Thread => {Thread.CurrentThread.ManagedThreadId} .");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Boiled Water ready.  On Thread - {Thread.CurrentThread.ManagedThreadId} .");
            return "Boiled Water";
        }

        //private void BoilWater()
        //{
        //    Console.WriteLine($"Boiling Water started. Thread - {Thread.CurrentThread.ManagedThreadId} .");
        //    Console.WriteLine($"Boiling... Boiling... Boiling... Thread - {Thread.CurrentThread.ManagedThreadId} .");
        //    Thread.Sleep(10000);
        //    Console.WriteLine($"Boiled Water ready.  Thread - {Thread.CurrentThread.ManagedThreadId} .");
        //}
    }
}
