using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon 
{
    //Makes the variables for enemy stats
    //Format for Enemies:
    //Enemy [Enemy Name Variable] = new Enemy(Name: "", Handedness: "", MaxHealth: 0, Health: 0, MaxMana: 0, Mana: 0, MaxDamage: 0, Damage: 0, MaxDefense: 0, Defense: 0, HealBarPoints: 0, Gold: 0);
    public struct Enemy
    {
        public string Name;
        public string Handedness;
        public float MaxHealth;
        public float Health;
        public float MaxMana;
        public float Mana;
        public float MaxDamage;
        public float Damage;
        public float Defense;
        public float MaxDefense;
        public float HealBarPoints;
        public int Gold;

        public Enemy(
            string Name,
            string Handedness,
            float MaxHealth,
            float Health,
            float MaxMana,
            float Mana,
            float MaxDamage,
            float Damage,
            float MaxDefense,
            float Defense,
            float HealBarPoints,
            int Gold
            )
        {
            this. Name = Name;
            this.Handedness = Handedness;
            this.MaxHealth = MaxHealth;
            this.Health = Health;
            this.MaxMana = MaxMana;
            this.Mana = Mana;
            this.MaxDamage = MaxDamage;
            this.Damage = Damage;
            this.MaxDefense = MaxDefense;
            this.Defense = Defense;
            this.HealBarPoints = HealBarPoints;
            this.Gold = Gold;

        }
    }

    internal class Game
    {
        //Makes the important variables that keep the game running
        public static int userChoice;
        public static int currentArea;
        public static bool gameOver;
        public static bool playerIsDead;
        public static bool playerWonBattle;

        //Makes the variables for the player's stats
        public static string playerName;
        public static string playerHandedness;
        public static float playerHealBar;
        public static float playerMaxHealBar;
        public static float playerMaxHealth;
        public static float playerHealth;
        public static float playerMaxMana;
        public static float playerMana;
        public static float playerMaxDamage;
        public static float playerDamage;
        public static float playerMaxDefense;
        public static float playerDefense;
        public static int playerPotions;
        public static int playerMaxPotions;
        public static int playerGold;

        //Make a function that will define the players stats
        public static void DefinePlayerStats()
        {
            //Get the players name
            Console.WriteLine("What is your name?");
            playerName = Console.ReadLine();
            Console.Clear();

            //Get playerHandedness
            userChoice = GetThreeOptionInput("Ok " + playerName + " what is your dominant hand?", "Left Handed", "Right Handed", "Ambidexterous");
            //Set player handedness to left
            if (userChoice == 1)
            {
                playerHandedness = ("Left");
                userChoice = 0; //Reset the user choice
            }
            //Set player handedness to right
            else if (userChoice == 2)
            {
                playerHandedness = ("Right");
                userChoice = 0; //Reset the user choice
            }
            //Set player handedness to ambidexterous
            else if (userChoice == 3)
            {
                playerHandedness = ("Ambidexterous");
                userChoice = 0; //Reset the user choice
            }

            //Set the players stats
            playerHealBar = 0.0f;
            playerMaxHealBar = 10f;
            playerMaxHealth = 20.0f;
            playerHealth = 20;
            playerMaxMana = 50.0f;
            playerMana = 50.0f;
            playerMaxDamage = 5.0f;
            playerDamage = 5.0f;
            playerMaxDefense = 0.0f;
            playerDefense = 0.0f;
            playerPotions = 3;
            playerMaxPotions = 3;
            playerGold = 50;
            //Do certian things to the players stats if their name is something specific
            if (playerName == "Bobligiferous The Twost")
            {
                playerGold = 500;
            }
            if (playerName == "Boblious" || playerName == "boblious")
            {
                playerDamage = 20;
            }
            if (playerName == "Sodakin")
            {
                playerPotions = 10;
                playerMaxPotions = 10;
            }
            //Subtract player damage by 1 if they are Ambidexterious 
            if (playerHandedness == ("Ambidexterous"))
            {
                playerDamage -= 1;
                playerMaxDamage -= 1;
            }
        }

        //Make a function that displays players current stats
        public static void DisplayPlayerStats()
        {
            Console.Clear();
            Console.WriteLine(playerName + "'s stats");
            Console.WriteLine("-------------------");
            Console.WriteLine("Handedness:" + Game.playerHandedness);
            Console.WriteLine("HealBar:" + Game.playerHealBar + "/" + Game.playerMaxHealBar);
            Console.WriteLine("Health:" + Game.playerHealth + "/" + Game.playerMaxHealth);
            Console.WriteLine("Mana:" + Game.playerMana + "/" + Game.playerMaxMana);
            Console.WriteLine("Damage:" + Game.playerDamage + "/" + Game.playerMaxDamage);
            Console.WriteLine("Defense:" + Game.playerDefense + "/" + Game.playerMaxDefense);
            Console.WriteLine("Potions:" + Game.playerPotions + "/" + Game.playerMaxPotions);
            Console.WriteLine("Gold:" + Game.playerGold);
            Console.WriteLine();
        }

        //Make a function for a two choice option
        public static int GetTwoOptionInput(string description, string option1, string option2)
        {
            string input = "";
            int inputRecieved = 0;

            // Input loop
            while (inputRecieved != 1 && inputRecieved != 2)
            {
                // Print options
                Console.WriteLine(description);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.Write("> ");

                // Get input from player
                input = Console.ReadLine();

                // If player selected the first option
                if (input == "1" || input == option1)
                {
                    // Set inputRecieved to be the first option
                    inputRecieved = 1;
                }

                // If player selected the second option
                else if (input == "2" || input == option2)
                {
                    // Set inputRecieved to be the first option
                    inputRecieved = 2;
                }

                // If neither are true
                else
                {
                    // Display error message
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            return inputRecieved;
        }

        //Make a function for a three choice option
        public static int GetThreeOptionInput(string description, string option1, string option2, string option3)
        {
            string input = "";
            int inputRecieved = 0;

            // Input loop
            while (inputRecieved != 1 && inputRecieved != 2 && inputRecieved != 3)
            {
                // Print options
                Console.WriteLine(description);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.WriteLine("3. " + option3);
                Console.Write("> ");

                // Get input from player
                input = Console.ReadLine();

                // If player selected the first option
                if (input == "1" || input == option1)
                {
                    // Set inputRecieved to be the first option
                    inputRecieved = 1;
                }

                // If player selected the second option
                else if (input == "2" || input == option2)
                {
                    // Set inputRecieved to be the second option
                    inputRecieved = 2;
                }

                // If player selected the third option
                else if (input == "3" || input == option3)
                {
                    // Set inputRecieved to be the third option
                    inputRecieved = 3;
                }

                // If none are true
                else
                {
                    // Display error message
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            return inputRecieved;
        }

        //Make a function that runs when a battle starts
        public static void PlayerGetsIntoBattle(Enemy Badguy)
        {
            bool nobodyIsDead = true;
            while (nobodyIsDead == true)
            {
                //Define player and enemy basic attack
                float playerTrueDamage = playerDamage - Badguy.Defense;
                float enemyTrueDamage = Badguy.Damage - playerDefense;
                //Define player and enemy magic attack
                float playerMagicDamage = playerDamage * 2;
                float enemyMagicDamage = playerDamage * 2;
                //Define player potion use
                float potionHealAmount = playerMaxHealth * .25f;

                Game.DisplayPlayerStats();
                Console.WriteLine();

                //Display enemy stats
                Console.WriteLine(Badguy.Name + "'s stats");
                Console.WriteLine("-------------------");
                Console.WriteLine("Handedness:" + Badguy.Handedness);
                Console.WriteLine("Health:" + Badguy.Health + "/" + Badguy.MaxHealth);
                Console.WriteLine("Damage:" + Badguy.Damage + "/" + Badguy.MaxDamage);
                Console.WriteLine("Defense:" + Badguy.Defense + "/" + Badguy.MaxDefense);
                Console.WriteLine("Mana:" + Badguy.Mana + "/" + Badguy.MaxMana);
                Console.WriteLine("Gold:" + Badguy.Gold);
                Console.WriteLine();

                userChoice = GetThreeOptionInput("What would you like to do?", "1.Sword Swing", "2.Magic Missle x2DMG(10Mana)", "3.Healing Potion(25% Max Health)");
                //Player attacks with Sword Swing
                if (userChoice == 1)
                {
                    Badguy.Health -= playerTrueDamage; //Deal trueDamage
                    Console.WriteLine("You delt " + playerTrueDamage + " to " + Badguy.Name + "!");
                    userChoice = 0; //Reset the user choice
                }
                //Player attacks with Magic Missle
                else if (userChoice == 2)
                {
                    Badguy.Health -= playerMagicDamage; //Deal trueDamage
                    playerMana -= 10;
                    Console.WriteLine("You delt " + playerMagicDamage + " to " + Badguy.Name + "!");
                    userChoice = 0; //Reset the user choice
                }
                //Player drinks a healing potion
                else if (userChoice == 3)
                {
                    playerHealth += potionHealAmount;
                    playerPotions -= 1;
                    Console.WriteLine("You drank the potion and healed " + potionHealAmount + " health!");
                    userChoice = 0; //Reset the user choice
                }

                //Enemy attacks
                if (Badguy.Health > 0 && playerHealth > 0)
                {
                    playerHealth -= enemyTrueDamage; //Deal trueDamage
                    Console.WriteLine(Badguy.Name + " dealt " + enemyTrueDamage + " to you!");
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                }

                //End the battle if the enemy dies
                if (Badguy.Health <= 0 )
                {
                    
                    Console.WriteLine("You won! " + Badguy.Name + " has been defeated.");

                    //Give the player the Gold from the enemy
                    playerGold += Badguy.Gold;
                    Console.WriteLine(Badguy.Name + " dropped " + Badguy.Gold + " gold!");

                    //Give the player the HealBarPoints from the enemy
                    playerHealBar += Badguy.HealBarPoints;
                    Console.WriteLine("Your HealBar has increased by " + Badguy.HealBarPoints);
                    //Apply the HealBar effect if the HealBar was maxed out
                    if (playerHealBar >= playerMaxHealBar)
                    {
                        Console.WriteLine("Your HealBar is maxed!");
                        Console.WriteLine("You have healed to full health and mana along with regaining any lost damage and defense!");
                        playerHealth = playerMaxHealth;
                        playerMana = playerMaxMana;
                        playerDamage = playerMaxDamage;
                        playerDefense = playerMaxDefense;
                    }

                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                    Game.playerWonBattle = true;
                    nobodyIsDead = false;
                }
                //End the battle if the player dies
                if (playerHealth <= 0)
                {
                    Console.WriteLine("You lost! " + Badguy.Name + " has defeated you.");
                    Console.WriteLine("Game over");
                    Console.WriteLine("Enter to exit...");
                    Console.ReadLine();
                    Game.playerIsDead = true;
                    nobodyIsDead = false;
                    break;
                }
            }
           
            
        }


        public void Run()
        {
            DefinePlayerStats();
            Game.currentArea = 0;
            Console.WriteLine("HelloDungeon says Hello, " + Game.playerName + ".");
            Console.WriteLine("Enter to continue...");
            Console.ReadLine();
            while (Game.gameOver == false)
            {
                //Area 1 Statue and Corridor
                if (Game.currentArea == 1)
                {
                    //Corridor or Statue Area
                    Game.DisplayPlayerStats();
                    Console.WriteLine(Game.playerName + ", you find yourself plundering an unexplored dungeon");
                    Game.userChoice = GetTwoOptionInput("Do you approach the ominous dark corridor or the odd statue guarding a door?", "Corridor", "Statue");
                    if (Game.userChoice == 1)
                    {
                        CorridorScenario corridorScenario = new CorridorScenario();
                        corridorScenario.Run();
                        Game.userChoice = 0; //Reset the user choice

                    } //Send player to CorridorScenario
                    if (Game.userChoice == 2)
                    {
                        StatueScenario statueScenario = new StatueScenario();
                        statueScenario.Run();
                        Game.userChoice = 0; //Reset the user choice

                    } //Send player to StatueScenario
                }
                
                // Area 2 Goblin fight
                if (Game.currentArea == 2)
                {
                    Game.DisplayPlayerStats();
                    Console.WriteLine("After a while you awake again");
                    Console.WriteLine("You look around ");
                    Console.ReadLine();

                    Game.DisplayPlayerStats();
                    Console.WriteLine("");
                }

                //If player dies give option to reset game
                if (Game.playerIsDead == true)
                {
                    Game.userChoice = GetTwoOptionInput("Would you like to restart?", "Yes", "No");
                    if (Game.userChoice == 1)
                    {
                        Game.DefinePlayerStats();
                        Game.playerIsDead = false;
                        Game.currentArea = 0;
                        //Actually start the game intro thingy
                        Console.Clear();
                        Console.WriteLine("HelloDungeon says Hello, " + Game.playerName + ".");
                        Console.WriteLine("Enter to continue...");
                        Console.ReadLine();
                    }
                    if (Game.userChoice == 2)
                    {
                        break;
                    }
                }

                //If the player is still alive and hasnt completed the dungeon
                else
                {
                    //put the player in the next area
                    Game.currentArea++;
                }
            }
        }
    }
}