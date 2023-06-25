using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunGame
{
    public class Dugger : Weapon
    {
        public bool IsDouble {  get; set; }
        private string _singleOrDuble;

        public Dugger()
        {
            GeneratePower();
            GenerateLethality();
            DoublePower();
        }

        static Random random = new Random();

        
        public override string ToString()
        {
            _singleOrDuble = IsDouble ? "Double" : "Single";
            return $"Dugger: " + base.ToString() + $" Dugger Type : {_singleOrDuble}";
        }
        

        public int DoublePower()
        {
            if(_singleOrDuble == "Double")
            {
                Power = (random.Next(0, 100)) * 2;
            }
            return Power;
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
    }
}
