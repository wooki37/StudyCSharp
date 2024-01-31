using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._05.WhileExam
{
    class WhileExam
    {
        public void Main()
        {
            int i = 10;

            while (i > 0)
            {
                Console.WriteLine($"i : {i--}");
            }
        }
    }
}
