﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._15.LINQ
{
    class Profile2
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class GroupByExam
    {
        public void Main()
        {
            Profile[] arrProfile =
            {
                new Profile(){Name="정우성", Height=186},
                new Profile(){Name="김태희", Height=158},
                new Profile(){Name="고현정", Height=172},
                new Profile(){Name="이문세", Height=178},
                new Profile(){Name="하하", Height=171}
            };
            var listProfile = from Profile in arrProfile
                              orderby Profile.Height
                              group Profile by Profile.Height < 175 into g
                              select new { GroupKey = g.Key, Profiles = g };

            foreach (var Group in listProfile)
            {
                Console.WriteLine($"- 175cm 미만? : {Group.GroupKey}");

                foreach (var profile in Group.Profiles)
                {
                    Console.WriteLine($">>> {profile.Name}, {profile.Height}");
                }
            }
            Console.ReadLine();
        }
    }
}
