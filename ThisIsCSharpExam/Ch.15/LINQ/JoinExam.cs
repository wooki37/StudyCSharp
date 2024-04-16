using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._15.LINQ
{
    class JoinProfile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class JoinProduct
    {
        public string Title { get; set; }
        public string Star {  get; set; }
    }
    class JoinExam
    {
        public void Main()
        {
            JoinProfile[] arrJoinProfile =
            {
                new JoinProfile(){Name="정우성", Height=186},
                new JoinProfile(){Name="김태희", Height=158},
                new JoinProfile(){Name="고현정", Height=172},
                new JoinProfile(){Name="이문세", Height=178},
                new JoinProfile(){Name="하하", Height=171}
            };
            JoinProduct[] arrJoinProduct =
            {
                new JoinProduct(){Title="비트", Star="정우성"},
                new JoinProduct(){Title="CF 다수", Star="김태희"},
                new JoinProduct(){Title="아이리스", Star="김태희"},
                new JoinProduct(){Title="모래시계", Star="고현정"},
                new JoinProduct(){Title="Solo 예찬", Star="이문세"},
            };
            var listProfile =
                from JoinProfile in arrJoinProfile
                join JoinProduct in arrJoinProduct on JoinProfile.Name equals JoinProduct.Star
                select new
                {
                    Name = JoinProfile.Name,
                    Work = JoinProduct.Title,
                    Height = JoinProfile.Height
                };
            Console.WriteLine("---내부 조인 결과---");
            foreach(var JoinProfile in listProfile)
            {
                Console.WriteLine("이름:{0}, 작품:{1}, 키:{2}cm",JoinProfile.Name, JoinProfile.Work, JoinProfile.Height);
            }
            listProfile =
                from JoinProfile in arrJoinProfile
                join JoinProduct in arrJoinProduct on JoinProfile.Name equals JoinProduct.Star
                into ps
                from JoinProduct in ps.DefaultIfEmpty(new JoinProduct() { Title = "그런거 없음" })
                select new
                {
                    Name = JoinProfile.Name,
                    Work = JoinProduct.Title,
                    Height = JoinProfile.Height
                };
            Console.WriteLine();
            Console.WriteLine("---외부 조인 결과---");

            foreach (var JoinProfile in listProfile)
            {
                Console.WriteLine("이름:{0}, 작품:{1}, 키:{2}cm", JoinProfile.Name, JoinProfile.Work, JoinProfile.Height);
            }
            Console.ReadLine();
        }
    }
}
