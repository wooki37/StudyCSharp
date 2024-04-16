using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._12.ExceptionExam
{
    class KillingProgram
    {
        public void Main()
        {
            int[] arr = { 1, 2, 3 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("종료");
        }
    }
}
