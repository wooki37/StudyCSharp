using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._15.LINQ
{
    class SimpleProfile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class SimpleLinq2
    {
        public void Main()
        {
            SimpleProfile[] arrSimpleProfile =
            {
                new SimpleProfile(){Name="정우성", Height=186},
                new SimpleProfile(){Name="김태희", Height=158},
                new SimpleProfile(){Name="고현정", Height=172},
                new SimpleProfile(){Name="이문세", Height=178},
                new SimpleProfile(){Name="하하", Height=171}
            };
            var simpleProfiles = arrSimpleProfile.
                Where(SimpleProfile => SimpleProfile.Height < 175).
                Select(SimpleProfile =>
                new
                {
                    Name = SimpleProfile.Name,
                    InchHeight = SimpleProfile.Height * 0.393
                });
            foreach (var SimpleProfile in simpleProfiles)
            {
                Console.WriteLine($"{SimpleProfile.Name}, {SimpleProfile.InchHeight}");
            }
            Console.ReadLine();
        }
    }
}
