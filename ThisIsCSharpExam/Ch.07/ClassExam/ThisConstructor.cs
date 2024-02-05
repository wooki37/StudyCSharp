using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._07.ClassExam
{
    class MyClass1
    {
        int a, b, c;

        public MyClass1()
        {
            this.a = 5425;
            Console.WriteLine("MyClass1()");
        }
        public MyClass1(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"MyClass1({b})");
        }
        public MyClass1 (int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"MyClass1({b}, {c})");
        }
        public void PrintFields()
        {
            Console.WriteLine($"a:{a}, b:{b}, c:{c}");
        }
    }
    class ThisConstructor
    {
        public void Main()
        {
            MyClass1 a = new MyClass1();
            a.PrintFields();
            Console.WriteLine();

            MyClass1 b = new MyClass1(1);
            b.PrintFields();
            Console.WriteLine();

            MyClass1 c = new MyClass1(10, 20);
            c.PrintFields();
        }
    }
}
