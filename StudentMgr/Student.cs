using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwjoo
{
    // Class fullname => namespace.class_name

    /// <summary>
    ///  hwjoo.Student 클래스 정의
    /// </summary>

    public class Student
    {
        //private string name;    // <= this.name
        private string address;
        public int age;

        #region 생성자
        public Student(string name, string address) // C# 생성자 선언 방식
        {
            this.Name = name;
            this.address = address;
        }

        public Student(string name) : this(name, null)
        {
        }
            // null -> empty
        public Student() : this(null)
        { 
        }
        #endregion
        /// <summary>
        /// getter of name
        /// </summary>
        /// <returns></returns>
       

        //public string Name {
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}

        public string Name
        {
            get; set;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            if (age < 0 || age > 121)
            {
                Console.WriteLine("나이는 음수나 120세를 넘을 수 없습니다.");
                return;
            }
            this.age = age;
        }

        // 시그니처 : method_name(type)
        public void printName()
        {
            Console.WriteLine("Name = " + Name);
        }
        public void printAddress()
        {
            Console.WriteLine("address = " + address);
        }
    }
}
