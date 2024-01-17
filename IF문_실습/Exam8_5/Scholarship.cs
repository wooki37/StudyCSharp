using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_5
{
    internal class Scholarship
    {
        public Scholarship()
        {

        }
        public void MakeStudent()
        {
            string name = null;
            SexEnum sex;
            int score;
            name = MyUtil.GetName();
            sex = MyUtil.GetSex();
            score = MyUtil.GetDigit();
            TestMe();
            EvaluateScholarShip(name, sex, score);
        }
        private void TestMe()
        {

        }
        public void EvaluateScholarShip(string name, SexEnum sex, int score) { 

            if (sex == SexEnum.오류)
            {
                MyUtil.ErrorMessage("성구분이 틀렸습니다.");
                return;
            }
            switch(sex)
            {
                case SexEnum.남성:
                    PrintMan(name, score);
                    break;
                case SexEnum.여성:
                    PrintWoman(score);
                    break;
            }
        }

        void PrintMan(string name, int score)
        {
            if (IsError(score)) return;
            if (score > 90) MyUtil.PrintMessage("우수장학생");
            else if (score > 80) MyUtil.PrintMessage("장학생");
            else MyUtil.PrintMessage("해당사항 없음");
        }
        void PrintWoman(int score)
        {
            if (IsError(score)) return;
            if (score > 90) MyUtil.PrintMessage("우수장학생");
            else if (score > 80) MyUtil.PrintMessage("장학생");
            else MyUtil.PrintMessage("해당사항 없음");
        }
        bool IsError(int value)
        {
            if (value == -2)
            {
                MyUtil.ErrorMessage("성적이 범위를 벗어났습니다.");
                return true;
            }
            return false;
        }
    }
}
