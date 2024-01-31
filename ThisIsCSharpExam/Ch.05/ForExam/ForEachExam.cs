using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._05.ForExam
{
    class ForEachExam
    {
        public void Main()
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4 };

            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}
