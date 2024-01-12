﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnimalShelter
{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        private DateTime _Birthday;
        private bool _IsQualified;
        public string Address;
        public string Description;

        public Customer(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._Birthday = birthday;

            this._IsQualified = Age >= 18;
        }
        // 아래 Age 속성과 같은 기능
        //public int GetAge()
        //{
        //    return _Age;
        //}
        //public void SetAge(int age)
        //{
        //    _Age = age;
        //    _IsQualified = age >= 18;
        //}

        public DateTime Birthday
        {
            get
            {
                return _Birthday;
            }
            set
            {
                _Birthday = value;
                _IsQualified = Age >= 18;
            }
        }

        public int Age
        {
            get { return DateTime.Now.Year - _Birthday.Year; }

        }
        // 아래 IsQualified 속성과 같은 기능
        //public bool GetIsQualified()
        //{
        //    return _IsQualified;
        //}
        public bool IsQualified
        {
            get
            {
                return _IsQualified;
            }
        }
        // 아래 FullName 속성과 같은 기능
        //public string GetFullName()
        //{
        //    return FirstName + " " + LastName;
        //}
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
