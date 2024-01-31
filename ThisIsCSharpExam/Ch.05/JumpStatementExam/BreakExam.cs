using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._05.JumpStatementExam
{
    class BreakExam
    {
        public void Main()
        {
            while (true)
            {
                Console.WriteLine("계속할까요?(예/아니요) : ");
                string answer = Console.ReadLine();

                if (answer == "아니요")
                    break;
            }
        }
    }
}
