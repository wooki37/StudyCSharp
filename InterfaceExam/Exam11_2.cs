using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExam
{
    internal class Exam11_2
    {
        public void Run()
        {
            Student2[] students = new Student2[]
            {
                new Student2("주현욱", 99, 2),
                new Student2("강감찬", 79, 1)
            };
            Array.Sort(students);
            foreach (Student2 st in students)
            {
                Console.WriteLine(st);
            }
        }
    }
    class Student2 : IComparable, IDisposable
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Id { get; set; }
        public Student2(string name, int score, int id)
        {
            Name = name;
            Score = score;
            Id = id;
        }
        public override string ToString()
        {
            return $"{Name}[{Id}][{Score}]";
        }
        StreamReader reader;

        public int CompareTo(object obj)
        {
            Student2 st = obj as Student2;
            int ret = Id - st.Id;
            return ret;
        }

        ~Student2()
        {
            Dispose(false);
        }
        bool disposed;  //false
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void aaa()
        {
            FileStream stream = new FileStream(@"d:\temp\aa.txt", FileMode.Open);
            reader = new StreamReader(stream);
                string buffer;
                while ((buffer = reader.ReadLine()) != null)
                {

                }
            }

        public void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                //C#에서 사용하는 IDiposable을 구현한 객체들 정리
                reader.Close();
                reader.Dispose();
            } else
            {
                // .NET Framework에서 관리되지 않는 자원들 정리
            }
            disposed = true;
        }
    }
}
