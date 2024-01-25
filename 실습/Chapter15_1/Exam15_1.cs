using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15_1
{
    class Exam15_1
    {
        ArrayList students = new ArrayList();
        public void Run()
        {
            ReadStudent();
            students.Sort();
            PrintStudent();
            WriteStudent();
        }
        private void WriteStudent()
        {
            FileStream stream = new FileStream(@"C:\Users\USER\Desktop\CSharp\StudyCSharp\실습\student1.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(stream, UTF8Encoding.UTF8);
            foreach (Student st in students)
                writer.WriteLine($"{st.Name}#{st.StudentSex}#{st.Score}");
            writer.Close();
        }

        private void PrintStudent()
        {
            for (int i = 0; i < students.Count; i++)
                Console.WriteLine(students[i]);
        }

        private void ReadStudent()
        {
            FileStream stream = new FileStream(@"C:\Users\USER\Desktop\CSharp\StudyCSharp\실습\student.txt", FileMode.Open);
            StreamReader reader = new StreamReader(stream, UTF8Encoding.UTF8);
            string buffer = null;
            int index = 0;
            while ((buffer = reader.ReadLine()) != null)
                InsertStudent(buffer, index++);
            reader.Close();
        }

        private void InsertStudent(string buffer, int index)
        {
            Student st = new Student();
            string[] tmp = buffer.Split('#');   // tmp[0], tmp[1], tmp[2]
            if (tmp.Length != 3)
                throw new Exception("텍스트 내용에 오류가 있습니다. " + buffer);
            st.Name = tmp[0];
            st.Score = Convert.ToInt32(tmp[2]); // int.Parse()
            int isex = int.Parse(tmp[1]);
            st.StudentSex = isex;
            students.Add(st);
        }
    }
}
