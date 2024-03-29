﻿//using System;
//using System.Threading;

//namespace ThisIsCSharpExam.Ch._19.ThreadExam
//{
//    class UsingMonitor
//    {
//        public void Main()
//        {
//            Counter counter = new Counter();

//            Thread incThread = new Thread(
//                new ThreadStart(counter.Increase));
//            Thread decThread = new Thread(
//                new ThreadStart(counter.Decrease));

//            incThread.Start();
//            decThread.Start();

//            incThread.Join();
//            decThread.Join();

//            Console.WriteLine(counter.Count);
//        }
//    }
//    class Counter
//    {
//        const int LOOP_COUNT = 1000;

//        readonly object thisLock;

//        private int count;
//        public int Count
//        {
//            get { return count; }
//        }
//        public Counter()
//        {
//            thisLock = new object();
//            count = 0;
//        }
//        public void Increase()
//        {
//            int loopCount = LOOP_COUNT;

//            while (loopCount-- > 0)
//            {
//                Monitor.Enter(thisLock);
//                try
//                {
//                    count++;
//                }
//                finally
//                {
//                    Monitor.Exit(thisLock);
//                }
//                Thread.Sleep(1);
//            }
//        }
//        public void Decrease()
//        {
//            int loopCount = LOOP_COUNT;
//            while (loopCount-- > 0)
//            {
//                Monitor.Enter(thisLock);
//                try
//                {
//                    count--;
//                }
//                finally
//                {
//                    Monitor.Exit(thisLock);
//                }

//                Thread.Sleep(1);
//            }
//        }
//    }
//}
