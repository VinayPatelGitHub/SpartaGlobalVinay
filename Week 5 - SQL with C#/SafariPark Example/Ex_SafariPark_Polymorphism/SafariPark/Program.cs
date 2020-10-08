using SafariPark;
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
            LaserGun gun1 = new LaserGun("Cod");
            LaserGun gun2 = new LaserGun("WorldWarZ");
            WaterPistol gun3 = new WaterPistol("Supersoaker");
            Camera gun4 = new Camera("Polaroid");
            Camera gun5 = new Camera("Nikon");

            Hunter hunter1 = new Hunter("Vinay", "Patel", gun1);
            Hunter hunter2 = new Hunter("Vinay", "Patel", gun3);
            Hunter hunter3 = new Hunter("Vinay", "Patel", gun5);

            List<IShootable> Guns = new List<IShootable>();
            Guns.Add(gun1);
            Guns.Add(gun2);
            Guns.Add(gun3);
            Guns.Add(gun4);
            Guns.Add(gun5);
            Guns.Add(hunter1);
            Guns.Add(hunter2);
            Guns.Add(hunter3);
            foreach (var item in Guns)
            {
                Console.WriteLine(item.Shoot());
            }

            Console.WriteLine("");
            Camera pentax = new Camera("Pentax");
            WaterPistol pistol = new WaterPistol("Supersoaker");
            LaserGun laserGun = new LaserGun("Acme");
            Hunter nish = new Hunter("Nish", "Mandal", pentax);
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = laserGun;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;








        }

        //public static void Main()
        //{


        //    //Hunter h = new Hunter("Terrence", "Babarinsa") { Age = 20 };

        //    //var hstring = h.ToString();
        //    //Console.WriteLine(hstring);

        //    List<Object> gameObjects = new List<object>()
        //    {

        //        new Person ("Nish", "Mandal"),
        //        new Airplane(400, 200, "Boeing"),
        //        new Vehicle(12, 20),
        //        new Hunter("Bear", "Grills", "Pentax")
        //    };


        //    //foreach (var  item in gameObjects)
        //    //{
        //    //    Console.WriteLine(item);
        //    //}

        //    Person huthaifa = new Person("Huthaifa", "Ahmed");
        //    Hunter fazal = new Hunter("Fazal", "Cheema", "Nikon");

        //    SpartaWrite(fazal);
        //}

        //public static void SpartaWrite(Object o)
        //{
        //    //Console.WriteLine(o.ToString());

        //    //if (o is Hunter)
        //    //{
        //    var person = (Person)o;
        //    Console.WriteLine(person.ToString());
        //    //Console.WriteLine(hunterObj.Shoot());

        //}
    }
}