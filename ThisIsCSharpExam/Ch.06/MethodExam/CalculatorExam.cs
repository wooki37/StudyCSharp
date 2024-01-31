using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._06.MethodExam
{
    class CalculatorExam
    {
        public void Main()
        {
            int result = CalculatorExam.Plus(3, 4);
            Console.WriteLine(result);

            result = CalculatorExam.Minus(5, 2);
            Console.WriteLine(result);
        }
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }
}
