﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._03.StringExam
{
    class StringModify
    {
        public void Main()
        {
            Console.WriteLine("ToLower() : '{0}'", "ABC".ToLower());
            Console.WriteLine("ToUpper() : '{0}'", "abc".ToUpper());

            Console.WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, " Sunny"));
            Console.WriteLine("Remove() : '{0}'", "I Don't Love You".Remove(2, 6));

            Console.WriteLine("Trim() : '{0}'", " No Spaces ".Trim());
            Console.WriteLine("TrimStart() : '{0}'", " No Spaces ".TrimStart());
            Console.WriteLine("TrimEnd() : '{0}'", " No Spaces ".TrimEnd());
        }
    }
}
