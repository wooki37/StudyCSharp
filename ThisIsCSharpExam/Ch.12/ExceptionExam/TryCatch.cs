using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._12.ExceptionExam
{
    class TryCatch
    {
        public void Main()
        {
            int[] arr = { 1, 2, 3 };

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"예외가 발생했습니다. : {e.Message}");
            }
            Console.WriteLine("종료");
        }
     }
}
