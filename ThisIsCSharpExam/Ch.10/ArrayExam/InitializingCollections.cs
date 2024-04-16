using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._10.ArrayExam
{
    class InitializingCollections
    {
        public void Main()
        {
            int[] arr = { 123, 456, 789 };

            ArrayList list = new ArrayList(arr);
            foreach(object item in list)
            {
                Console.WriteLine($"ArrayList : {item}");
            }
            Console.WriteLine();

            Stack stack = new Stack(arr);
            foreach(object item in stack)
            {
                Console.WriteLine($"Stack : {item}");
            }
            Console.WriteLine();

            Queue queue = new Queue(arr);
            foreach(object item in queue)
            {
                Console.WriteLine($"Queue : {item}");
            }
            Console.WriteLine();

            ArrayList list2 = new ArrayList() 
            {
                11, 22, 33
            };
            foreach(object item in list2)
            {
                Console.WriteLine($"ArrayList2 : {item}");
            }
            Console.WriteLine();

            // 딕셔너리 초기자
            Hashtable ht = new Hashtable()
            {
                ["하나"] = 1,
                ["둘"] = 2,
                ["셋"] = 3
            };
            Console.WriteLine(ht["하나"]);
            Console.WriteLine(ht["둘"]);
            Console.WriteLine(ht["셋"]);
        }
    }
}
