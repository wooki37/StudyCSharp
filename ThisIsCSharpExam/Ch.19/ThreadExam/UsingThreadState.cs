﻿using System;
using System.Threading;

namespace ThisIsCSharpExam.Ch._19.ThreadExam
{
    class UsingThreadState
    {
        private static void PrintThreadState(ThreadState state)
        {
            Console.WriteLine("{0, -16} : {1}", state, (int)state);
        }
        public void Main() {

        PrintThreadState(ThreadState.Running);

        PrintThreadState(ThreadState.StopRequested);

        PrintThreadState(ThreadState.SuspendRequested);

        PrintThreadState(ThreadState.Background);

        PrintThreadState(ThreadState.Unstarted);

        PrintThreadState(ThreadState.Stopped);

        PrintThreadState(ThreadState.WaitSleepJoin);

        PrintThreadState(ThreadState.Suspended);

        PrintThreadState(ThreadState.AbortRequested);

        PrintThreadState(ThreadState.Aborted);

        PrintThreadState(ThreadState.Aborted | ThreadState.Stopped);
        }
    }
}
