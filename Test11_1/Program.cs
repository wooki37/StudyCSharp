using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 5;
            Console.WriteLine("숫자를 입력하세요 : ");
            string value = Console.ReadLine();
            int c = int.Parse(value);
            Console.WriteLine("c 값은 " + c);
            
            // 비교연산자, 논리연산자, bool 값
            switch(c)
            {
                case 0:
                    Console.WriteLine("0이 입력되었습니다");
                    break;
                case 1:
                    Console.WriteLine("1이 입력되었습니다");
                    break;
                case 2:
                    Console.WriteLine("2이 입력되었습니다");
                    break;
                default:
                    Console.WriteLine("해당사항이 없습니다.");
                    break;
            }
        }
    }
}
