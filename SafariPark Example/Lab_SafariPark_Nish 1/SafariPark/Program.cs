using System;
using System.Security.Cryptography.X509Certificates;

namespace SafariPark
{
	class Program
	{
		static void Main(string[] args)
		{
			//Person fazal = new Person();
			//fazal.Age = 12;

			Point3D pt3d = new Point3D(5, 8, 2);

			Person diogo = new Person("Diogo", "Matos") { Age = 20 };

			DemoMethod(pt3d, diogo);

			Console.WriteLine(pt3d.y);
			Console.WriteLine(diogo.Age);

		}

		static void DemoMethod(Point3D pt, Person p)
		{
			pt.y = 1000;
			p.Age = 92;
		}

	}
}
