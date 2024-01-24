using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace Exam9_1
{
    internal class Animal
    {
        public int Age { get; set; }
        public SexEnum Sex { get; set;}
        public int Weight { get; set; }

        public Animal() {
            Console.WriteLine("Animal " + this.ToString());
                }

        public void Sleep() {
            System.Console.WriteLine("I'm sleeping now");
                }
        public void Eat() { System.Console.WriteLine("I'm eating now"); }
        public void Walk() { System.Console.WriteLine("I'm walking on the street"); }

        public override string ToString()
        {
            return "I'm Animal";
        }
    }
}
