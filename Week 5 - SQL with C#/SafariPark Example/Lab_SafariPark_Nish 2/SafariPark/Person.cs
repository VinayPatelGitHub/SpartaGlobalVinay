﻿using SafariPark;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassApp
{
    public class Person : IMovable
    {
        protected string _firstName;
        private string _lastName;
        private int _age;

        public int Age
        {
            get { return _age; }
            set { if (value >= 0) _age = value; }
        }

        public Person(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }

        public Person(string firstName, string lastName, int age) : this(firstName, lastName)
        {
            Age = age;
        }

        public Person()
        {
        }
        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";
        }

        
        
        public string Move(int times)
        {
            return $"Walk along {times} times";
        }

        public string Move()
        {
            return $"Walk along";
        }

    }
}