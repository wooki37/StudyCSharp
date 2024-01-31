using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._05.WhileExam
{
    class DoWhileExam
    {
        public void Main() {
        int i = 10;

        do {
                Console.WriteLine("a) i : {0}", i--);
            }
            while (i > 0);
        do {
                Console.WriteLine("b) i : {0}", i--);   // 여기에서 i는 이미 0이지만 이 코드는 한 차례 실행됩니다.
            }
            while (i > 0);
        }
    }
}
