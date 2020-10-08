using ClassesApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
	public class Hunter : Person
	{
		private string _camera;

		public Hunter(string fName, string lName, string camera = "") : base(fName, lName)
		{
			_camera = camera;
		}

		public Hunter()
		{
		}

		public string Shoot()
		{
			return $"{GetFullName()} has taken a photo with their {_camera}";
		}

		public override string ToString()

		{
			return $"{base.ToString()} Camera: {_camera}";
		}
		
	}

	public class MonsterHunter : Hunter
	{
		private string _weapon;
		public MonsterHunter(string fName, String lName, string camera, string weapon) : base(fName, lName)		
		{
			_weapon = weapon;			
		}

		public sealed override string ToString()

		{
			return $"{base.ToString()} Weapon: {_weapon}";
		}

	}

}
