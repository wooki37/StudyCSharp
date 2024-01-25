using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam
{
    class Exam_1
    {
        public void Main() {
            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int x = 128;    // sbyte의 최대값 127보다 1 큰 수
            Console.WriteLine(x);

            sbyte y = (sbyte)x; // 오버플로 발생!
            Console.WriteLine(y);
        }
    }
}
