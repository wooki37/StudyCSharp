using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_7
{
    internal class Exam8_7
    {
        public void Run() 
        {
            TimesTable tt = new TimesTable();
            for (int i = 2; i <= 9; i++)
            {
                tt.Base = i;
                tt.PrintBase();
                Console.WriteLine("--------------------------");
            }
            
        }
    }
}
