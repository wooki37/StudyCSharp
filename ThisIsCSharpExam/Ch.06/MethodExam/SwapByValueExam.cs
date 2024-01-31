using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._06.MethodExam
{
    class SwapByValueExam
    {
        public void Main()
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"x:{x}, y:{y}");

            Swap(x, y);

            Console.WriteLine($"x:{x}, y:{y}");
        }
        public static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
    }
}
