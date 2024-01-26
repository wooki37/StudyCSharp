using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._03.EnumExam
{
    class Exam_03
    {
        enum DialogResult { YES = 10, NO, CANCEL, CONFIRM = 50, OK }
        public void Main()
        {
            DialogResult result = DialogResult.YES;

            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);
        }
    }
}
