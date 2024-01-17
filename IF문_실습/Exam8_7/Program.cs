using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            Exam8_7 obj = new Exam8_7();
                        obj.Run();*/
            FindValue();
        }

        private static void FindValue()
        {
            for (int i = 0; i < 51; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine($"i = {i}");
            }
        }
    }
}
