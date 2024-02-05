using System;

namespace ThisIsCSharpExam.Ch._06.MethodExam
{
    class NamedParameter
    {
        public void Main()
        {
            PrintProfile(name: "박찬호", phone: "010-123-1234");
            PrintProfile(phone: "010-123-1234", name: "박지성");
            PrintProfile("박세리", "010-123-1234");
            PrintProfile("손흥민", phone: "010-567-5678");
        }
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }
    }
}
