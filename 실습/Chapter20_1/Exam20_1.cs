using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_1
{
    static class MyClass
    {
        public static int GetWordCount(this string txt)
        {
            return txt.Split(' ').Length;
        }
        public static bool IsDigit(this string txt)
        {
                int tmp;
                return int.TryParse(txt, out tmp);
        }
        public static int? ConvertToInt(this string txt)
        {
            int tmp;
            if (int.TryParse(txt, out tmp)) return tmp;
            return null;
        }
    }
    class Exam20_1
    {
        public void Run()
        {
            string kk = "83619238a";
            Console.WriteLine(kk.ConvertToInt());
        }
    }
}
