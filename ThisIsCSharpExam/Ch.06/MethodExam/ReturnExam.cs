﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._06.MethodExam
{
    class ReturnExam
    {
        public void Main()
        {
            Console.WriteLine($"10번째 피보나치 수 : {Fibonacci(10)}");

            PrintProfile("", "123-4567");
            PrintProfile("씨샵이", "456-1230");
        }
        static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void PrintProfile(string name, string phone)
        {
            if (name == "")
            {
                Console.WriteLine("이름을 입력해주세요.");
                return;
            }
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }
    }
}
