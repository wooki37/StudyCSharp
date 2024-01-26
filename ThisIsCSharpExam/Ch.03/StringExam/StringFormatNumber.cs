using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._03.StringExam
{
    class StringFormatNumber
    {
        public void Main()
        {
            // D : 10진수
            Console.WriteLine("10진수 : {0:D}", 123);
            Console.WriteLine("10진수 : {0:D5}", 123);

            // X : 16진수
            Console.WriteLine("16진수 : 0x{0:X}", 0xFF1234);
            Console.WriteLine("16진수 : 0x{0:X8}", 0xFF1234);

            // N : 숫자
            Console.WriteLine("숫자 : {0:N}", 123456789);
            Console.WriteLine("숫자 : {0:N0}", 123456789);    // 자릿수 0은 소수점 이하를 제거함

            // F : 고정 소수점
            Console.WriteLine("고정 소수점 : {0:F}", 123.45);
            Console.WriteLine("고정 소수점 : {0:F5}", 123.456);

            // E : 공학용
            Console.WriteLine("공학 : {0:E}", 123.456789);

        }
    }
}
