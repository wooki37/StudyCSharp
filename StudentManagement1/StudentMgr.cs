using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class StudentMgr
    {
        struct Student
        {
        public Grade StGrade { get; set; }  // PK
        public StudentClass StClass { get; set; }   // PK
        public int StNumber { get; set; }   // PK
        public string Name { get; set; }    // Not Null
        public Sex StSex { get; set; }  // Enum Sex 참조
    }

        public void Run()
        {
            Student st = RegistStudent();
            Printme(st);
        }
        public void Printme(Student st)
        {
            Console.WriteLine(st.StGrade1 + ":" + st.StClass1 + ":" + st.StNumber1 + " [" + st.Name1 + "]");
        }

        private Student RegistStudent()
        {
            Console.WriteLine("학년[숫자만 입력]: ");
            string grade = Console.ReadLine();
            Console.WriteLine("반: ");
            string stclass = Console.ReadLine();
            Console.WriteLine("번호: ");
            string stnumber = Console.ReadLine();
            Console.WriteLine("이름: ");
            string stname = Console.ReadLine();
            Student st1 = new Student();
            st1.StGrade1 = (Grade)Enum.Parse(typeof(Grade).grade);

            return st1;
        }
    }
}
