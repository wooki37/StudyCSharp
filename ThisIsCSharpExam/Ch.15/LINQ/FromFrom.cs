using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._15.LINQ
{
    class Class
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }

    class FromFrom
    {
       public void Main()
        {
            Class[] arrClass =
            {
                new Class(){Name="연두반", Score=new int[]{99, 80, 40, 24}},
                new Class(){Name="분홍반", Score=new int[]{60, 87, 29, 59}},
                new Class(){Name="파랑반", Score=new int[]{90, 70, 50, 30}},
                new Class(){Name="노랑반", Score=new int[]{81, 79, 92, 65}},
            };
            var classes = from c in arrClass
                          from s in c.Score
                          where s < 60
                          orderby s
                          select new { c.Name, Lowest = s };

            foreach(var c in classes)
            {
                Console.WriteLine($"낙제 : {c.Name} ({c.Lowest})");
            }
            Console.ReadLine();
        }
    }
}
