using System;

namespace ThisIsCSharpExam.Ch._07.ClassExam
{
    class ConstructorExam
    {
        public void Main()
        {
            Cat1 kitty = new Cat1("키티", "하얀색");
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat1 nero = new Cat1("네로", "검은색");
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
    class Cat1
    {      
        public Cat1()
        {
            Name = "";
            Color = "";
        }
        public Cat1(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }
        ~Cat1()
        {
            Console.WriteLine($"{Name} : 잘가");
        }
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }
}
