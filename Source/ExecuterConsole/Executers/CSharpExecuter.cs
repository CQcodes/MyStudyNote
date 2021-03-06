﻿using CSharp;
using CSharp.DesignPattern.FactoryPattern;
using CSharp.ThreadSynchronization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ExecuterConsole.Executers
{
    public class CSharpExecuter
    {
        public static void Execute<T>() where T : ICSharp, new() => new T().Execute();
        public static void KitchenThread() => new KitchenThread().Execute();
        public static void FactoryPatternDemo() => new FactoryPatternDemo().Execute();
        public static void VarvsDynamicvsObjectDemo() => new VarvsDynamicvsObject().Execute();
        public static void EqualsMethodDemo() => new EqualsMethodDemo().Execute();
        public static void InheritanceDemo() => new InheritanceDemo().Execute();
        public static void MutexDemo() => new MutexDemo().Execute();
        public static void AutoResetEventDemo() => new AutoResetEventDemo().Execute();
        public static void ManualResetEventDemo() => new ManualResetEventDemo().Execute();
        public static void MonitorDemo() => new MonitorDemo().Execute();
        public static void LockObjectDemo() => new LockObjectDemo().Execute();
        public static void SemaphoreSlimDemo() => new SemaphoreSlimDemo().execute();
        public static void GenericDelegate() => GenericDelegates.GenericDelegateDemo();
        static void FileDownloader()
        {
            Console.WriteLine($"-------------------------- Main Entry --------------------------on Thread - {Thread.CurrentThread.ManagedThreadId}, IsBGT : {Thread.CurrentThread.IsBackground}, isTPL : {Thread.CurrentThread.IsThreadPoolThread}");

            //await FilieDownloader.PerformFileDownloadAsync();
            FilieDownloader.PerformFileDownloadUsingThreads();

            Console.WriteLine($"-------------------------- Main Exit --------------------------on Thread - {Thread.CurrentThread.ManagedThreadId}, IsBGT : {Thread.CurrentThread.IsBackground}, isTPL : {Thread.CurrentThread.IsThreadPoolThread}");
            Console.ReadLine();
        }
        static void AnonymousMethodDemo()
        {
            Anonymous a = new Anonymous();
            a.anonymousMethod = new PrintNameHelper((string f, string l) => { Console.WriteLine($"{f} {l}"); });
            a.anonymousMethod("Abhishek", "Mishra");

            var anonymousMethod = new PrintNameHelper((string f, string l) => {
                Console.WriteLine($"{f} {l} direct delegate");
            });
            anonymousMethod("Abhishek", "Mishra");

            PrintNameHelper del = delegate (string f, string l)
            {
                Console.WriteLine($"{f} {l} direct delegate 2");
            };
            del("siku", "mishra");
        }
        static void DelegateEventDemo()
        {
            var video = new Video { Title = "MyVideoTitle.mp4" };
            var videoEncoder = new VideoEncoder();
            // instanciate messaging services
            var slack = new SlcakService();
            var mail = new MailService();
            var sms = new SmsService();
            // subscribe to event
            videoEncoder.VideoEncoded += slack.SendSlackMessageOnVideoCoded;
            videoEncoder.VideoEncoded += mail.SendMailOnVideoCoded;
            videoEncoder.VideoEncoded += sms.SendSmsOnVideoCoded;
            videoEncoder.VideoEncoded += (sender, videoEventArgs) =>
            {
                Console.WriteLine($"Anonymous message sender. => {videoEventArgs.EncodedVideo.Title}");
            };
            videoEncoder.Encode(video);
        }
        static void Comparer()
        {
            var sComparer = new StudentComparer();
            var s1 = new Student() { FirstName = "f1", LastName = "l1", rollNo = 1 };
            var s2 = new Student() { FirstName = "f2", LastName = "l2", rollNo = 2 };
            var s3 = new Student() { FirstName = "f3", LastName = "l3", rollNo = 3 };
            var allStudents = new List<Student> { s3, s1, s2 };
            allStudents.Sort(sComparer);
            Console.WriteLine($"{Utility<Student>.Max(s1, s2).FirstName}");
            Console.WriteLine($"{string.Join(',', allStudents.Select(s => s.rollNo + " => " + s.FirstName).ToList())}");
        }
        static void Inheritance()
        {
            Child cc = new Child();
            cc.Print();
            Parent pp = new Parent();
            pp.Print();
            Parent pc = new Child();
            pc.Print();
        }
    }
}
