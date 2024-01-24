using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_4
{
    internal class Exam8_4
    {
        public void Run()
        {
            Scholarship scholarship = new Scholarship();
            Student st = new Student();
            st.ReadProperty();
            scholarship.MyStudent = st;
            scholarship.EvaluateScholarShip();
        }
    }
}
