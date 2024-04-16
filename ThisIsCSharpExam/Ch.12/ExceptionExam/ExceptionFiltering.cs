﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._12.ExceptionExam
{
    class FilterableException : Exception
    {
        public int ErrorNo { get; set; }
    }
    class ExceptionFiltering
    {
        public void Main()
        {
            Console.WriteLine("Enter Number Between 0~10");
            string input = Console.ReadLine();
            try
            {
                int num = Int32.Parse(input);

                if (num < 0 || num > 10)
                {
                    throw new FilterableException() { ErrorNo = num };
                }
                else
                {
                    Console.WriteLine($"Output : {num}");
                }
            }
            catch (FilterableException e) when (e.ErrorNo < 0)
            {
                Console.WriteLine("Negative input is not allowed");
            }
            catch (FilterableException e) when (e.ErrorNo > 10)
            {
                Console.WriteLine("Too big number is not allowed");
            }
        }
    }
}
