using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._12.ExceptionExam
{
    class StackTraceExam
    {
        public void Main()
        {
            try
            {
                int a = 1;
                Console.WriteLine(3 / --a);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
