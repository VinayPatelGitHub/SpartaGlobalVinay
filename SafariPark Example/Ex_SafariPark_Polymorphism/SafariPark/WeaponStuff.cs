using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public interface IShootable
    {
        string Shoot();
    }

    public abstract class Weapon : IShootable
    {
        private string _brand;

        public virtual string Shoot()
        {
            return $"(brand:{_brand}) fired.";
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public Weapon(string brand)
        {
            _brand = brand;
        }
    }

    public class LaserGun : Weapon
    {
        public LaserGun(string brand) : base(brand)
        {            
        }
        public override string Shoot()
        {
            return $"Zap-Zap!! Laser Gun {base.Shoot()}";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class WaterPistol : Weapon
    {
        public WaterPistol(string brand) : base(brand)
        {
        }
        public override string Shoot()
        {
            return $"Swoosh!! Water Pistol {base.Shoot()}";
        }
        public override string ToString()
        {
            return $"{base.ToString()}";
        }

    }

    public class Camera : IShootable
    {
        private string _brand;

        public Camera (string brand)
        {
            _brand = brand;
        }

        public string Shoot()
        {
            return $"Schwap!!  A Photo was taken using Camera Brand: {_brand}";
        }
        public override string ToString()
        {
            return $"{_brand}";
        }

    }


}
