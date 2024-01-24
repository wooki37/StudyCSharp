using System;

namespace Chapter17_1
{
    internal class Student : IComparable
    {
        public string Name { get; set; }
        public int StudentSex { get; set; }
        public int Score { get; set; }

        public int CompareTo(object obj)
        {
            Student st1 = obj as Student;
            return Name.CompareTo(st1.Name);
        }
        public override string ToString()
        {
            return $"{Name}[{StudentSex}][{Score}]";
        }
    }
}