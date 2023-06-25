using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunGame
{
    public class Player : Weapon
    {
        public int Health { get; set; } = 300;
        public Weapon PlayerWeapon { get; set; }

        static Random random = new Random();

        List<Weapon> weapon = new List<Weapon>();


        public void ChooseWeapon(List<Weapon> weapons)
        {
            Console.WriteLine("Choose your weapon! Enter number : ");
            int firstChoise = int.Parse(Console.ReadLine());


            for (int i = 0; i < weapons.Count; i++)
            {
                PlayerWeapon = weapons[firstChoise - 1];

            }
            Console.WriteLine(PlayerWeapon);
        }

        public int Attack()
        {
            return PlayerWeapon.Power;
        }


        public override string ToString()
        {
            return $"Player health {Health}, weapon {PlayerWeapon}";
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
