using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.DesignPattern
{
    /*
     * Sealed : restricts inheritance
     */
    public sealed class SingletonLazyLoading
    {
        private static SingletonLazyLoading singletonInstance;
        private static readonly object _lock = new object();

        /*
         * Private constructor ensures that the class is not initialised outside the class
         */
        private SingletonLazyLoading()
        {
            Console.WriteLine("Singleton Instance Created.");
        }

        /*
         * Static Public property to return the class instance using the private field
         */
        public static SingletonLazyLoading GetInstance
        {
            get
            {
                if(singletonInstance == null)
                {
                    lock (_lock)
                    {
                        if (singletonInstance == null)
                            singletonInstance = new SingletonLazyLoading();
                    }
                }
                return singletonInstance;
            }
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine($"Singleton instance method printing : {message}");
        }
    }

    public sealed class SingletonEagerLoading
    {
        //private static SingletonEagerLoading singletonInstance = new SingletonEagerLoading();
        private static readonly Lazy<SingletonEagerLoading> singletonInstance = new Lazy<SingletonEagerLoading>(()=> new SingletonEagerLoading());

        private SingletonEagerLoading()
        {
            Console.WriteLine("Singleton Instance Created.");
        }

        public static SingletonEagerLoading GetInstance
        {
            get
            {
                //return singletonInstance;
                return singletonInstance.Value;
            }
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine($"Singleton instance method printing : {message}");
        }
    }

    public class TestSingleton
    {
        public void Method()
        {
            var o = SingletonLazyLoading.GetInstance;
            o.PrintMessage("First Message.");
        }
    }
}
