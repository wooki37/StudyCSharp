using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hwjoo;

namespace StudentMgr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "홍길동";
            student1.age = 1000;
            student1.SetAge(-1);
            Console.WriteLine(student1.Name);
        }
    }
    /// <summary>
    /// <para>StudentMgr.Student 클래스 정의</para>
    /// <para>이것은 테스트 입니다.</para>
    /// </summary>
    //class Student
    //{

    //}
}
