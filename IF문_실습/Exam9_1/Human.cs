using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam9_1
{
    internal class Human : Animal
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Human() {
            Console.WriteLine("Human " + this.ToString());
        }

        public void Drawing() { System.Console.WriteLine("I'm drawing a picture"); }
        public void Study() { System.Console.WriteLine("I'm studying CSharp"); }
    }
}
