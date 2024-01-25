using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter18_2
{
    class Exam18_2
    {
        public void Run()
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            Console.WriteLine(list1?.Count);
                int? ret = list2?.Count;
                Console.WriteLine(ret == null ? "(null)" : ret.ToString());
        }
    }
}
