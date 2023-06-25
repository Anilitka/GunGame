using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GunGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Weapon> weapons = new List<Weapon>()
            {
                new Bow(),
                new Gun(),
                new Dugger(){IsDouble = true},
                new Bow(),
                new Gun(),
                new Dugger(){IsDouble = false},

            };
            foreach (var weapon in weapons)
            {
                Console.WriteLine(weapon);
            }

            Console.WriteLine();

            Weapon max = weapons[0];

            for(int i = 0; i < weapons.Count; i++)
            {
                if (weapons[i].Power > max.Power)
                {
                    max = weapons[i];
                }

            }
            Console.WriteLine($"Max power {max}");

            Console.WriteLine();

            Player player = new Player();
            player.ChooseWeapon(weapons);
            Console.WriteLine("Congratulation, you've chosen your weapon");
            Player player1 = new Player();
            player1.ChooseWeapon(weapons);
            Console.WriteLine("Congratulation, you've chosen your weapon");
            Console.WriteLine();
            Console.WriteLine("Start fight!");
            while (player.Health >= 0 && player1.Health >= 0)
            {


                int dmg = player.Attack();
                player.Health -= dmg;
                player.Health = player.Health < 0 ? 0 : player.Health;

                Console.WriteLine($"Player Health {player.Health} DMG {dmg}");

                if (player.Health  <= 0 || player1.Health <= 0)
                     break;

                int dmg1 = player1.Attack();
                player1.Health -= dmg1;
                player1.Health = player1.Health < 0 ? 0 : player1.Health;
                Console.WriteLine($"Player1 Health {player1.Health} DMG {dmg1}");


            }


        }

    }
}
