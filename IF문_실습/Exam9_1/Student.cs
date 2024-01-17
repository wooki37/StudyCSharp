using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam9_1
{
    internal class Student : Human
    {
        public int Grade {  get; set; }
        public int StudentClass { get; set; }
        public int StudentId { get; set; }

        public void 시험을보다() { Console.WriteLine("저는 시험을 보는 중입니다."); }
    }
}
