using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExam
{
    internal class Exam11_1
    {
        public void Run()
        {
            //TestStudent();
            TestBasic();
        }

        private void TestStudent()
        {
            Student[] students = new Student[]
                {new Student("홍길동", 89, 1), new Student("황진이", 77, 2)};
            IEnumerator enumerator = students.GetEnumerator();
            while(enumerator.MoveNext()) Console.WriteLine(enumerator.Current);
        }

        private void TestBasic()
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //IEnumerator enumerator = intArray.GetEnumerator();
            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    Console.WriteLine(intArray[i]);
            //}
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}
            // foreach()
            //foreach (int i in intArray) Console.WriteLine(i);

            string str = "abcdefg";
            foreach (char c in str) Console.WriteLine(c);
        }
    }
    class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Id { get; set; }
        public Student(string name, int score, int id)
        {
            Name = name;
            Score = score;
            Id = id;
        }
        public override string ToString()
        {
            return $"{Name}[{Id}][{Score}]";
        }
    }
}
