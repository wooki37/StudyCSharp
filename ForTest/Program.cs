﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 6;
            do
            {
                Console.WriteLine("i = " + i);
                i++;
            }
            while (i < 5);
        }
    }
}
