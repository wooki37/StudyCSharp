using System;
using MyLibrary;


namespace Exam8_2
{
    public class Exam8_2
    {
        public void Run()
        {
            PrintResult(MyUtil.GetDigit());
        }

        private void PrintResult(int digit)
        {
            if (digit < 0 || digit > 100)
            {
                Console.WriteLine("[오류] 숫자가 아니거나 범위를 벗어났습니다.");
                return;
            }
            if (digit >= 90)
            {
                Console.WriteLine("우수");
                Console.WriteLine("수고하셨습니다.");
            }
            else
            {
                Console.WriteLine("보통");
                Console.WriteLine("더 노력하세요");
            }
        }
    }
}
