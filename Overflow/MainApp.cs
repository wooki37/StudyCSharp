using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.WriteLine(a);

            a = a + 1;
            Console.WriteLine(a);
        }
    }
}
