using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp
{
    public class KitchenThread : ICSharp
    {
        /// <summary>
        /// When we create a new thread by using Thread class, it creates a new thread other than what is available in ThreadPool
        /// But if we use Task for executing methods other than the Main thread, it uses the worker-threads from ThreadPool
        /// which is very efficient
        /// </summary>
        public void Execute()
        {
            Thread.CurrentThread.Name = "Main thread";
            Console.WriteLine($"is {Thread.CurrentThread.Name} a threadpool thread : '{Thread.CurrentThread.IsThreadPoolThread}'");

            Console.WriteLine($"starting Lunch preparation on {Thread.CurrentThread.Name}");

            Thread t1 = new Thread(MakeRice);
            Thread t2 = new Thread(MakeDessert);
            var starterTask = Task.Factory.StartNew(MakeStarters);

            t1.Start();t2.Start();

            Console.WriteLine("Waiting...");

            t1.Join();t2.Join();
            starterTask.GetAwaiter().GetResult();

            Console.WriteLine("Lunch is ready.");
            Console.WriteLine($"{Thread.CurrentThread.Name} is serving food");

        }

        private void MakeRice()
        {
            Thread.CurrentThread.Name = "Rice thread";

            Console.WriteLine($"starting Rice on {Thread.CurrentThread.Name}");
            Console.WriteLine($"is {Thread.CurrentThread.Name} a threadpool thread : '{Thread.CurrentThread.IsThreadPoolThread}'");
            Thread.Sleep(5 * 1000);
            Console.WriteLine($"Rice is ready on {Thread.CurrentThread.Name}");
        }

        private void MakeDessert()
        {
            Thread.CurrentThread.Name = "Dessert thread";

            Console.WriteLine($"starting Dessert on {Thread.CurrentThread.Name}");
            Console.WriteLine($"is {Thread.CurrentThread.Name} a threadpool thread : '{Thread.CurrentThread.IsThreadPoolThread}'");
            Thread.Sleep(3 * 1000);
            Console.WriteLine($"Dessert is ready on {Thread.CurrentThread.Name}");
        }

        private void MakeStarters()
        {
            Thread.CurrentThread.Name = "Starters thread";

            Console.WriteLine($"starting Dessert on {Thread.CurrentThread.Name}");
            Console.WriteLine($"is {Thread.CurrentThread.Name} a threadpool thread : '{Thread.CurrentThread.IsThreadPoolThread}'");
            Thread.Sleep(4 * 1000);
            Console.WriteLine($"Starters is ready on {Thread.CurrentThread.Name}");
        }
    }
}
