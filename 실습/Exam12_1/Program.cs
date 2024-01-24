using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exam12_1
{
    internal class Program
    {
        int i;
        static void Main(string[] args)
        {

            Student st = new Student();
            Student st2 = st;
            st.Name = "Lee";
            st2.Name = "Kim";
            Console.WriteLine(st.Name);
            Console.WriteLine(st2.Name);
            AAA(st);
        }
        static void AAA(Student st)
        {

        }
    }
    struct Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
