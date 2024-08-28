using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon 
{
    internal class Game
    {
        public static string playerHandedness;
        public static string userChoice;
        public static float maxPlayerHealth;
        public static float playerHealth;
        public static float maxPlayerMana;
        public static float playerMana;
        public static float playerDamage;
        public static int playerGold;


        public void Run()
        {
            //Get the players name and dominant hand
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ok " + playerName + " what is your dominant hand?");
            while (userChoice != "1" && userChoice != "2" && userChoice != "3")
            {
                Console.WriteLine("Type 1: Left Handed | Type 2: Right handed | Type 3: Ambidexterous");
                userChoice = Console.ReadLine();
                if (userChoice == "1")
                {
                    playerHandedness = ("Left");
                }
                if (userChoice == "2")
                {
                    playerHandedness = ("Right");
                }
                if (userChoice == "3")
                {
                    playerHandedness = ("Ambidexterous");

                }
            }
            userChoice = "0"; //Reset the user choice


            // Set the players stats
            maxPlayerHealth = 20.0f;
            playerHealth = 20.0f;
            maxPlayerMana = 50.0f;
            playerMana = 50.0f;
            playerDamage = 5.0f;
            playerGold = 50;

            // Do certian things to the players stats if their name is something specific
            if (playerName == "Bobligiferous The Twost")
            {
                playerGold = 500;
            }
            if (playerName == "Boblious")
            {
                playerDamage = 20;
            }


            
            Console.Clear();
            Console.WriteLine("HelloDungeon says hi, " + playerName + ".");
            Console.WriteLine("Enter to continue...");
            Console.ReadLine();


            //Display player current stats
            Console.Clear();
            Console.WriteLine("Handedness:" + playerHandedness);
            Console.WriteLine("Health:" + playerHealth);
            Console.WriteLine("Damage:" + playerDamage); 
            Console.WriteLine("Mana:" + playerMana);
            Console.WriteLine("Gold:" + playerGold);

            //Corridor or Statue choice
            Console.WriteLine("");
            Console.WriteLine( playerName + ", you find yourself plundering an unexplored dungeon");
            Console.WriteLine("Do you approach the ominous dark corridor or the odd statue guarding a door?");
            Console.WriteLine("");
            while (userChoice != "1" && userChoice != "2")
            {
                Console.WriteLine("Type 1: Corridor | Type 2: Statue");
                userChoice = Console.ReadLine();
                if (userChoice == "1")
                {
                    userChoice = "0"; //Reset the user choice
                    CorridorScenario corridorScenario = new CorridorScenario();
                    corridorScenario.Run();
                    if (CorridorScenario.tookTorch == true)
                    {
                        break;
                    }
                    
                }
                if (userChoice == "2" || CorridorScenario.returned == true)
                {
                    userChoice = "0"; //Reset the user choice
                    StatueScenario statueScenario = new StatueScenario();
                    statueScenario.Run();

                    break;
                }
            }
            


            //Display player current stats
            Console.Clear();
            Console.WriteLine("Handedness:" + playerHandedness);
            Console.WriteLine("Health:" + playerHealth);
            Console.WriteLine("Damage:" + playerDamage); 
            Console.WriteLine("Mana:" + playerMana);
            Console.WriteLine("Gold:" + playerGold);
            Console.WriteLine("");

            Console.WriteLine("GRAAA");

            

        }
    }
}
