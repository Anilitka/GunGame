using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunGame
{
    public class Gun : Weapon
    {
        private int _bulletQuantity { get; set; }

       static Random random = new Random();

        public Gun()
        {
            GeneratePower();
            GenerateLethality();
            GenerateBullet();
        }
        public int GenerateBullet()
        {

            if ((GeneratePower() >= 50) && (GenerateLethality() >= 50))
            {
                _bulletQuantity = random.Next(0, 50);
            }
            else
            {
                _bulletQuantity = random.Next(50, 100);
            }
            return _bulletQuantity;
        }
        public override string ToString()
        {
            return $"Gun: " + base.ToString() + $" Bullet Quantity : {_bulletQuantity}";
        }

        public override int GeneratePower()
        {
            Power = random.Next(0, 100);
            return Power;
        }

        public override int GenerateLethality()
        {
            Lethality = random.Next(0, 100);
            return Lethality;
        }

        public int BulletQuntity
        {
            get { return _bulletQuantity; }
            set
            {
                if (value < 0)
                {
                    throw new BulletExeption();
                }
                else
                {
                    _bulletQuantity = value;
                }

            }
        }
    }
}
