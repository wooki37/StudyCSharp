using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //학생
            //학년, 반, 번호, 학번, ...
            //사람
            //성명, 키, 혈액형, 국적, 주소, 전화번호, ...
            //동물
            //나이, 성별, 몸무게, 

            //Object

            Student st = new Student();
            Console.WriteLine(st.ToString());
            Human h1 = st;  //h1은 자식인 student를 가리키고 있다
            //Student st2 = h1 as Student;    // as는 컴파일 타입 전에 읽는다.
            //Student st3 = (Student)h1;
            Human h2 = new Human();
            Student st2 = h1 as Student;

            Animal ani1 = new Animal();
            Animal ani2 = new Animal();
            bool ret = ani1.Equals(ani2);
            int c = 1;


            Type type = ani1.GetType();
            Console.WriteLine("type test :" + type.FullName);
            Console.WriteLine("ani1 " + ani1.GetType());
            Console.WriteLine();


            //bool ret = ani1 is Human;
            //int a = 1;
        }
    }
}
