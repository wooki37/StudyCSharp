using System;

namespace ThisIsCSharpExam.Ch._06.MethodExam
{
    class OptionalParameter
    {
        public void Main()
        {
            PrintProfile("중근");
            PrintProfile("관순", "010-1234-1234");
            PrintProfile(name: "봉길");
            PrintProfile(name: "동주", phone: "010-5678-5678");
        }
        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }
    }
}
