using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpater19_1
{
    class Exam19_1
    {
        public void Run()
        {
            var student = new Student();
            student.Name = "홍길동";
            student.Score = 100;

            var student2 = new Student { Name = "홍길동", Score = 100 };

            var st = new { Name = "황진이", Score = 80 };
            PrintMe(st);
        }
        public void PrintMe(dynamic st)
        {
            Console.WriteLine(st.Name);
            Console.WriteLine(st.Score);
        }
    }

    class Student
    { 
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
