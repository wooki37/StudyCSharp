using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam
{
    class Exam_3
    {
        public void Main()
        {
            int a = 500;
            Console.WriteLine(a);

            uint b = (uint)a;
            Console.WriteLine(b);

            int x = -30;
            Console.WriteLine(x);

            uint y = (uint)x;   // 언더플로
            Console.WriteLine(y);
        }
    }
}
