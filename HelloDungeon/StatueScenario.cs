using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    internal class StatueScenario
    {
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Handedness:" + Game.playerHandedness);
            Console.WriteLine("Health:" + Game.playerHealth);
            Console.WriteLine("Damage:" + Game.playerDamage);
            Console.WriteLine("Mana:" + Game.playerMana);
            Console.WriteLine("Gold:" + Game.playerGold);
            Console.WriteLine();
            Console.WriteLine("StatueScenario");
            Console.ReadKey();
        }
    }
}
