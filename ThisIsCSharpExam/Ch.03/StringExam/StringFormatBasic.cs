using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._03.StringExam
{
    class StringFormatBasic
    {
        public void Main()
        {
            string fmt = "{0,-20}{1,-15}{2,30}";

            Console.WriteLine(fmt, "Publisher", "Author", "Title");
            Console.WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            Console.WriteLine(fmt, "Hanbit", "Sanghyun Park", "This is C#");
            Console.WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");
        }
    }
}
