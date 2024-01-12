using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_1
{
    public class IfTestMgr
    {
        short test1213 = 1;

        int ttt = 0;
        string test = string.Empty;

        public IfTestMgr(string message)
        {
            test = message;
        }

        public void Run()
        {
            PrintResult(GetDigit());
        }

        private void PrintResult(int digit)
        {
            if (digit < 0 || digit > 100)
            {
                Console.WriteLine("[오류] 숫자가 아니거나 범위를 벗어났습니다.");
                return;
            }
            if (digit > 90)
            {
                Console.WriteLine(string.Format("{0} 입니다.", test));
                Console.ReadLine();
            }
        }

        private int GetDigit()
        {
            Console.WriteLine("숫자를 입력하세요[0 ~ 100] : ");
            string val = Console.ReadLine();
            return ConvertString2Int(val);  // val == -1은 에러
        }
        private int ConvertString2Int(string str)
        {
            bool ret = int.TryParse(str, out int result);
            if (ret)
                return result;
            else
                return - 1; // 0 ~ 100이 점수 / -1 : error
        }
    }
}
