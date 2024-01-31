using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._05.SwitchExam
{

    class SwitchExam_2
    {
        public void Main()
        {
            string s = Console.ReadLine();
            object obj = null;
            if (int.TryParse(s, out int out_i))
                obj = out_i;
            else if (float.TryParse(s, out float out_f))
                obj = out_f;
            else
                obj = s;

            switch (obj)
            {
                //case int:
                //    Console.WriteLine($"{(int)obj}는 int 형식입니다.");
                //    break;
                //case float :
                //    Console.WriteLine($"{(float)obj}는 float 형식입니다.");
                //    break;
                default :
                    Console.WriteLine($"{obj}는()은 모르는 형식입니다.");
                    break;
            }
        }
    }
}
