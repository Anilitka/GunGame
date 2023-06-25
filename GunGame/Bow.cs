using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunGame
{
    public class Bow : Weapon
    {
         public int Accuracy { get; set; }
        private int _arrowQuantity { get; set; }

        static Random random = new Random();

        public Bow()
        {
            GeneratePower();
            GenerateLethality();
            GenerateAccuracy();
            GenerateArrowQuantity();
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
        public int ArrowQuantity
        {
            get { return _arrowQuantity; }
            set
            {
                if (value < 0)
                {
                    throw new BulletExeption();
                }
                else
                {
                    _arrowQuantity = value;
                }

            }
        }
        public int GenerateAccuracy()
        {
            if((GeneratePower() >= 50) && (GenerateLethality() >= 50))
            {
                Accuracy = random.Next(0,50);
            }
           
            else
            {
                Accuracy = random.Next(50,100);
            }
            return Accuracy;
        } 

        public int GenerateArrowQuantity()
        {
            if((GenerateLethality() >= 50) && (GeneratePower() >= 50))
            {
                _arrowQuantity = random.Next(0,50);
            }
            else
            {
                _arrowQuantity = random.Next(50,100);
            }
           return _arrowQuantity;
        }
        public override string ToString()
        {
            return $"Bow: " + base.ToString() + $" Accuracy : {Accuracy}, Arrow Quantity : {_arrowQuantity}";
        }

        
    }
}
