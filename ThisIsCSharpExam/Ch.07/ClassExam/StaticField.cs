using System;

namespace ThisIsCSharpExam.Ch._07.ClassExam
{
    class StaticField
    {
        public void Main()
        {
            Console.WriteLine($"Global.count : {Global.count}");

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();

            Console.WriteLine($"Global.count : {Global.count}");
        }
    }
    class Global
    {
        public static int count = 0;
    }
    class ClassA
    {
        public ClassA()
        {
            Global.count++;
        }
    }
    class ClassB
    {
        public ClassB()
        {
            Global.count++;
        }
    }
}
