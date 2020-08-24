using ClassesApp;
using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace SafariPark
{
    public class Program
    {
        public static void Main()
        {
            List<object> gameObjects = new List<object>()
            {
                new Person ("Nish", "Mandal"),
                new Airplane(400,200,"Boeing"),
                new Vehicle(12,20),
                new Hunter("Bear", "Grills", "Pentax")
            };

            //foreach(var item in gameObjects)
            //{
            //    Console.WriteLine(item); // different results of the same method - polymorphism
            //}

            //Airplane a = new Airplane(200, 100, "JetsRUs")
            //{ NumPassengers = 150 };
            //a.Ascend(500);
            //Console.WriteLine(a.Move(3));
            //Console.WriteLine(a);
            //a.Descend(200);
            //Console.WriteLine(a.Move());
            //a.Move();
            //Console.WriteLine(a);
            //Hunter h = new Hunter("Terrence", "Babarinsa") { Age = 20 };

            //var hstring = h.ToString();
            //Console.WriteLine(hstring);

            Person huthaifa = new Person("Huthaifa", "Ahmed");
            Hunter fazal = new Hunter("Fazal", "Cheema", "Nikon");

            SpartaWrite(huthaifa);
            SpartaWrite(fazal);

        }

        public static void SpartaWrite(Object o)
        {
            Console.WriteLine(o.ToString());

            if (o is Hunter)
            {
                var hunterObj = (Hunter)o;
                Console.WriteLine(hunterObj.Shoot());
            }
        }

    }


}