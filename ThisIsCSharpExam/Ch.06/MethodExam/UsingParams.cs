﻿using System;

namespace ThisIsCSharpExam.Ch._06.MethodExam
{
    class UsingParams
    {
        public void Main()
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"Sum : {sum}");
        }
        static int Sum(params int[] args)
        {
            Console.Write("Summing...");
            int sum = 0;
            for (int i = 0; i < args.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");
                Console.Write(args[i]);
                sum += args[i];
            }
            Console.WriteLine();

            return sum;
        }
    }
}
