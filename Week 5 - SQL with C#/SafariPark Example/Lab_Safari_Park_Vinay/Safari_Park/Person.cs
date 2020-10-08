using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace Safari_Park
{
	public class Person
	{
		private string _firstName;
		private string _lastName;

		private int _age;
		public int Age
		{
			get { return _age; }
			set { if (value >= 0) _age = value; }
		}


		public Person() { }

		public Person(string fName, string lName, int aAge)
		{
			_firstName = fName;
			_lastName = lName;
			_age = aAge;
		}

		public Person(string fName, string lName)
		{
			_firstName = fName;
			_lastName = lName;
		}

		public string GetFullName()
		{
			return $"{_firstName} {_lastName}";
		}

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";
		}

    }
}








//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Text;

//namespace Safari_Park
//{
//    public class Person
//    {
//        private string _firstName;
//        private string _lastName;
//        //public int Age {get; set; }

//        private int _age;
//        public int Age
//        {
//            get { return _age; }
//            set { if (value>= 0 ) _age = value; }
//        }

//        //public int Age { get; private set; } //can't just set, needs a method to set it


//        public Person()
//        {
//        }
//        public Person(string fName, string lName)
//        {
//            _firstName = fName;
//            _lastName = lName;
//        }
//        public Person(string fName, string lName, int aAge)
//        {
//            _firstName = fName;
//            _lastName = lName;
//            _age = aAge;
//        }

//        public string GetFullName()
//        {
//            return $"{_firstName} {_lastName}";
//        }

//        //public string FullName
//        //{
//        //    get { return $"{_firstName} {_lastName}"; }
//        //    set { _firstName = value; }
//        //    set // can't have to sets in a properties
//        //}

//    }
//}
