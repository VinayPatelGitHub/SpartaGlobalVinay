using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Lab_Comparing_objects
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var nish = new Person("Nish", "Mandal") { Age = 30 };
            var nishy = new Person("Nish", "Mandal") { Age = 30 };
            var areSame = nish.Equals(nishy);
            Console.WriteLine(areSame);

            List<Person> personList = new List<Person>
                {
                    new Person("Cath", "Cookson"),
                    new Person("Bob", "Builder"){Age = 25 },
                    new Person("sdg", "tuyu"),
                    new Person("hjg", "jkljk"){Age = 25 },
                };
            var bobOne = new Person("Bob", "Builder") { Age = 25 };
            var hasBob = personList.Contains(bobOne);
            Console.WriteLine(hasBob);

            Console.WriteLine(nish.CompareTo(nishy));

            Console.WriteLine("");
            Console.WriteLine("");
            foreach (var item in personList)
            {
                Console.WriteLine(item.GetFullName());
            }
            personList.Sort();
            Console.WriteLine("");
            foreach (var item in personList)
            {
                Console.WriteLine(item.GetFullName());
            }


        }
        
        
        
        public class Person : IEquatable<Person>, IComparable<Person>

        {
            private string _firstName;
            private string _lastName;
            private int _age;
            public Person() { }
            public Person(string fName, string lName)
            {
                _firstName = fName;
                _lastName = lName;
            }


            public int Age
            {
                get { return _age; }
                set { if (value >= 0) _age = value; }
            }

            public override bool Equals(object obj)
            {
                return Equals(obj as Person);
            }

            public bool Equals(Person other)
            {
                return other != null &&
                       _firstName == other._firstName &&
                       _lastName == other._lastName &&
                       _age == other._age &&
                       Age == other.Age;
            }

            public string GetFullName()
            {
                return $"{_firstName} {_lastName}";
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_firstName, _lastName, _age, Age);
            }

            public static bool operator ==(Person left, Person right)
            {
                return EqualityComparer<Person>.Default.Equals(left, right);
            }

            public static bool operator !=(Person left, Person right)
            {
                return !(left == right);
            }

            public int CompareTo([AllowNull] Person other)
            {
                if (other == null) return 1;
                if (this._lastName != other._lastName)
                {
                    return this._lastName.CompareTo(other._lastName);
                }
                else if (this._firstName != other._firstName)
                {
                    return this._firstName.CompareTo(other._firstName);
                }
                else { return this.Age.CompareTo(other.Age); }
            }

        }
    }
}
