using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunGame
{
    public abstract class Weapon
    {
        public int Power { get; set; }
        public int Lethality { get; set; }

       static Random random = new Random();
        public abstract int GeneratePower();

        public abstract int GenerateLethality();
        
        public override string ToString()
        {
            return $"Power: {Power}, Lethality : {Lethality}";
        }
    }
}
