using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._03.StringExam
{
    class StringSlice
    {
        public void Main()
        {
            string greeting = "Good Morning";

            Console.WriteLine(greeting.Substring(0,5));
            Console.WriteLine(greeting.Substring(5));
            Console.WriteLine();

            string[] arr = greeting.Split(new string[] {" "}, StringSplitOptions.None);
            Console.WriteLine("Word Count : {0}", arr.Length);

            foreach(string element in arr) Console.WriteLine("{0}", element);
        }
    }
}
