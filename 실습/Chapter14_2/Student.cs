using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static Chapter14_2.StudentEnum;

namespace Chapter14_2
{
    internal class Student
    {
        public string Name { get; set; }
        public Sex StudentSex { get; set; }
        public int Score { get; set; }

        public override string ToString()
        {
            return $"{Name}[{StudentSex}][{Score}]";
        }
    }
}
