using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 예제_3
{
    class Program
    {
       static public int a = 0;

        static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine("a = " + a--);
            Console.WriteLine("a = " + a);
        }
        static private void Func1(int a)
        {
            a = 2;
            string str = null;
            string str1 = str ?? "NULL";
            Console.WriteLine(str1);
        }
    }
}
