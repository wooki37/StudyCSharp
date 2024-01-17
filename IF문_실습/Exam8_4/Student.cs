using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_4
{
    internal class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public SexEnum Sex { get; set; }

        public void ReadProperty()
        {
            Name = MyUtil.GetName();
            Score = MyUtil.GetDigit(0, 100);
            Sex = MyUtil.GetSex();
        }
    }
}
