
using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
	public class Hunter : Person, IShootable
	{
		public IShootable Shooter {get; set;}

		public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
		{
			Shooter = shooter;
		}

		public Hunter()
		{
		}

		public string Shoot()
		{
			return $"Schwap!! {GetFullName()} took a photo using Camera Brand: {Shooter}";
		}

		public override string ToString()

		{
			return $"{base.ToString()} Camera: {Shooter}";
		}
		
	}

	//public class MonsterHunter : Hunter
	//{
	//	private string _weapon;
	//	public MonsterHunter(string fName, String lName, string camera, string weapon) : base(fName, lName)		
	//	{
	//		_weapon = weapon;			
	//	}

	//	public sealed override string ToString()

	//	{
	//		return $"{base.ToString()} Weapon: {_weapon}";
	//	}

	//}

}
