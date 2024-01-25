using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter18_1
{
    class Exam18_1
    {
        public void Run()
        {
            Member m = new Member();
            if (m.GetMarried.HasValue)
            Console.WriteLine(m.GetMarried == true ? "기혼" : "미혼");
            else
                Console.WriteLine("정보없음");
            int? aa = null;
            aa = 10;
            int? bb = aa;
            aa = bb;
        }
    }
    class Member
    {
        //bool getMarried;
        //public bool GetMarried { get { return getMarried; } set { getMarried = value; } }
        public bool? GetMarried { get; set; }   // Nullable<bool> = bool? 같은 타입이다.
    }
}
