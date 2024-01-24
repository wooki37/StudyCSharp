using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_10
{
    internal class Exam8_10
    {
        public void Run() {
            for (int i = 0; i < 5; i++)
            {
                PrintBlank(i);
                PrintStar(i);
                PrintNewLine();
            }
        }
        void PrintStar(int i)
        {
            // i는 0부터 4가지 연속된 값이 넘어옴.
            for (int j = 0; j < i * 2 + 1; j++)
                Console.Write("*");
        }
        void PrintBlank(int i)
        {
            for (int k = 0; k < 4 - i; k++)
                Console.Write(" ");
        }
        void PrintNewLine()
        {
            Console.WriteLine();
        }
    }
}
