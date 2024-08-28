using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    internal class Game
    {
        public void Run()
        {
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Alright " + playerName + " these are your stats:");
            float maxPlayerHealth = 20.0f;
            float playerHealth = 20.0f;
            float maxPlayerMana = 50.0f;
            float playerMana = 50.0f;
            float playerDamage = 5.0f;
            int playerGold = 50;

            if (playerName == "Bobligiferous The Twost")
                playerGold = 500;
            if (playerName == "Boblious")
                playerDamage = 20;


            Console.WriteLine("Hello, " + playerName + ".");
            Console.WriteLine("");
            Console.WriteLine("Welcome to the dungeon.");
            Console.WriteLine("");
            Console.WriteLine("Health:" + playerHealth);
            Console.WriteLine("Damage:" + playerDamage);
            Console.WriteLine("Mana:" + playerMana);
            Console.WriteLine("Gold:" + playerGold);
            Console.WriteLine("");
            Console.WriteLine( playerName + ", you find yourself plundering an unexplored dungeon");
            Console.WriteLine("Do you approach the ominous dark corridor or the odd statue guarding a door?");
            Console.WriteLine("");
            Console.WriteLine("1: Corridor | 2: Statue");
            

        }
    }
}
