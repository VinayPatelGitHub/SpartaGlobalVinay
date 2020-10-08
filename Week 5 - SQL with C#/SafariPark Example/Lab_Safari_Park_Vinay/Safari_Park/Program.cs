using System;
using System.Security.Cryptography.X509Certificates;

namespace Safari_Park
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(500);
            a.Move(3);
            a.Descend(200);
            Console.WriteLine(a);


            Hunter h = new Hunter("Vinay", "Patel") { Age = 24 };
            Hunter h2 = new Hunter("Fazal", "Cheema") { Age = 23 };
            Console.WriteLine(h);


            //Console.WriteLine($"h HashCode:{h.GetHashCode()}");
            //Console.WriteLine($"h Equals h2?:{h.Equals(h2)}");
            //Console.WriteLine($"h type:{h.GetType()}");
            //Console.WriteLine($"h ToString:{h.ToString()}");

            //Person cathy = new Person("Cathy", "French");
            //Console.WriteLine(cathy.Age);
            //cathy.Age = 22;
            //Console.WriteLine(cathy.Age);

            //Console.WriteLine(cathy.GetFullName());

            //Person nish;
            //nish = new Person("Nish", "Mandal");
            //Console.WriteLine(nish.GetFullName());

            //public Person () // 
            //{
            //    Person fazal = new Person();
            //    fazal.Age = 12;
            //    fazal._lastname = "sadsd" //can't because private
            //}

            // boxing
            //int i = 123;
            //object o = i;

            //structs
            //Public struct Point3D
            //{
            //    Public int x, y, z;
            //    Public Point3D(int x, int y, int z)
            //    {
            //        this.x = x;
            //        this.y = y;
            //        this.z = z;
            //    }
            //}




        }
        }
}
