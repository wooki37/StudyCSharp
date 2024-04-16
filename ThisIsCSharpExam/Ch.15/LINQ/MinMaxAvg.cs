using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ThisIsCSharpExam.Ch._15.LINQ
{
    class Profile4
    {
        public string Name { get; set; }

        public int Height { get; set; }
    }

    class MinMaxAvg
    {
        public void Main()
        {
            Profile4[] profiled4Arr1 =
            {
                new Profile4(){Name="정우성", Height=186},
                new Profile4(){Name="김태희", Height=158},
                new Profile4(){Name="고현정", Height=172},
                new Profile4(){Name="이문세", Height=178},
                new Profile4(){Name="하하", Height=171}
            };
            var heightStat = from profile4 in profiled4Arr1
                             group profile4 by profile4.Height < 175 into g
                             select new
                             {
                                 Group = g.Key == true ? "175미만" : "175이상",
                                 Count = g.Count(),
                                 Max = g.Max(Profile4 => Profile4.Height),
                                 Min = g.Min(Profile4 => Profile4.Height),
                                 Average = g.Average(Profile4 => Profile4.Height)
                             };
            foreach (var stat in heightStat)
            {
                Console.Write("{0} - Count:{1}, Max:{2}, ", stat.Group, stat.Count, stat.Max);
                Console.WriteLine("Min:{0}, Average:{1}", stat.Min, stat.Average);
            }
            Console.ReadLine();
        }
    }
}
