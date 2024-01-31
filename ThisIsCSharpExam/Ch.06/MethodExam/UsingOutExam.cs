using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._06.MethodExam
{
    class UsingOutExam
    {
        public void Main()
        {
            int a = 20;
            int b = 3;
            // int c;
            // int d;

            Divide(a, b, out int c, out int d);

            Console.WriteLine($"a:{a}, b:{b}:, a/b:{c}, a%b:{d}");

        }

        public static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
    }
}
