using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        /// <summary>
        /// Define all the important game running variables and player stat variables
        /// </summary>
        //Makes the important variables that keep the game running
        Random randomNumber = new Random();
        public static int userChoice;
        public static int currentArea;
        public static bool gameOver;
        public static bool playerIsDead;
        public static bool playerWonBattle;
        public static bool playerOnNGPlus;
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


        /// <summary>
        /// Make all the Functions
        /// </summary>
        //Make a function that fakes a crash
        static void FakeCrash()
        {
            bool fakeCrashing = true;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\\C:\\Users\\s248007\\Desktop\\HelloDungeon\\HelloDungeon\\bin\\Debug\\net8.0\\HelloDungeon.exe (process 666) exited with code N/A.");
                Console.WriteLine("To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.");
                Console.WriteLine("Press any key to close this window . . .");
                Console.ReadKey();
                Thread.Sleep(1000);
                Console.WriteLine("ERROR Failed to end debugging trying again");
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.Clear();
                if (i == 2)
                {
                    Console.WriteLine("\\C:\\Users\\s248007\\Desktop\\HelloDungeon\\HelloDungeon\\bin\\Debug\\net8.0\\HelloDungeon.exe (process 666) exited with code N/A.");
                    Console.WriteLine("To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.");
                    Console.WriteLine("Press any key to close this window . . .");
                    Thread.Sleep(2500);
                    Console.WriteLine("\\C:\\Users\\s248007\\Desktop\\HelloDungeon\\HelloDungeon\\bin\\Debug\\net8.0\\HelloDungeon.exe (process 666) exited with code N/A.");
                    Console.WriteLine("To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.");
                    Console.WriteLine("Press any key to close this window . . .");
                    Thread.Sleep(2000);
                    Console.WriteLine("\\C:\\Users\\s248007\\Desktop\\HelloDungeon\\HelloDungeon\\bin\\Debug\\net8.0\\HelloDungeon.exe (process 666) exited with code N/A.");
                    Console.WriteLine("To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.");
                    Console.WriteLine("Press any key to close this window . . .");
                    Thread.Sleep(1500);
                    Console.WriteLine("\\C:\\Users\\s248007\\Desktop\\HelloDungeon\\HelloDungeon\\bin\\Debug\\net8.0\\HelloDungeon.exe (process 666) exited with code N/A.");
                    Console.WriteLine("To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.");
                    Console.WriteLine("Press any key to close this window . . .");
                    Thread.Sleep(1250);
                    Console.WriteLine("\\C:\\Users\\s248007\\Desktop\\HelloDungeon\\HelloDungeon\\bin\\Debug\\net8.0\\HelloDungeon.exe (process 666) exited with code N/A.");
                    Console.WriteLine("To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.");
                    Console.WriteLine("Press any key to close this window . . .");
                    Thread.Sleep(1000);
                    Console.WriteLine("\\C:\\Users\\s248007\\Desktop\\HelloDungeon\\HelloDungeon\\bin\\Debug\\net8.0\\HelloDungeon.exe (process 666) exited with code N/A.");
                    Console.WriteLine("To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.");
                    Console.WriteLine("Press any key to close this window . . .");
                    Thread.Sleep(100);
                    Console.WriteLine("\\C:\\Users\\s248007\\Desktop\\HelloDungeon\\HelloDungeon\\bin\\Debug\\net8.0\\HelloDungeon.exe (process 666) exited with code N/A.");
                    Console.WriteLine("To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.");
                    Console.WriteLine("Press any key to close this window . . .");
                    Thread.Sleep(100);
                    Console.WriteLine("\\C:\\Users\\s248007\\Desktop\\HelloDungeon\\HelloDungeon\\bin\\Debug\\net8.0\\HelloDungeon.exe (process 666) exited with code N/A.");
                    Console.WriteLine("To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.");
                    Console.WriteLine("Press any key to close this window . . .");
                    Thread.Sleep(100);
                    Console.WriteLine("\\C:\\Users\\s248007\\Desktop\\HelloDungeon\\HelloDungeon\\bin\\Debug\\net8.0\\HelloDungeon.exe (process 666) exited with code N/A.");
                    Console.WriteLine("To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.");
                    Console.WriteLine("Press any key to close this window . . .");
                    Thread.Sleep(100);
                    Console.WriteLine("\\C:\\Users\\s248007\\Desktop\\HelloDungeon\\HelloDungeon\\bin\\Debug\\net8.0\\HelloDungeon.exe (process 666) exited with code N/A.");
                    Console.WriteLine("To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.");
                    Console.WriteLine("Press any key to close this window . . .");
                    Thread.Sleep(100);
                }
            }
            int fakeCrashingTime = 0;
            while (fakeCrashingTime != 1000)
            {
                Console.WriteLine("\\C:\\Users\\s248007\\Desktop\\HelloDungeon\\HelloDungeon\\bin\\Debug\\net8.0\\HelloDungeon.exe (process 666) exited with code N/A.");
                Console.WriteLine("To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.");
                Console.WriteLine("Press any key to close this window . . .");
                fakeCrashingTime += 1;
            }
            Console.WriteLine("");
            Console.WriteLine("Crashed lmao");
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
        //Make a function that will define the players stats
        public static void DefinePlayerStats()
        {
            //Get the players name
            Console.WriteLine("What is your name?");
            playerName = Console.ReadLine();
            Console.Clear();
            if (playerName == "SkipToNG+")
            {
                playerOnNGPlus = true;
                return;
            }

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
                playerMaxDamage = 20;
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
        public static void PlayerGetsIntoBattle(Enemy Badguy1)
        {
            userChoice = 0;
            //Define player and enemies basic attack
            float playerTrueDamage1 = playerDamage - Badguy1.Defense;
            float enemy1TrueDamage = Badguy1.Damage - playerDefense;
            //Define player and enemies magic attack
            float playerMagicDamage = playerDamage * 2;
            float enemy1MagicDamage = Badguy1.Damage * 2;
            //Define player potion use
            float potionHealAmount = playerMaxHealth * .25f;

            //Sets Badguy1's stats to be equal to their max stats in case of randomNumber being used
            if (Badguy1.Health != Badguy1.MaxHealth || Badguy1.Damage != Badguy1.MaxDamage || Badguy1.Defense != Badguy1.MaxDefense)
            {
                Badguy1.Health = Badguy1.MaxHealth;
                Badguy1.Damage = Badguy1.MaxDamage;
                Badguy1.Defense = Badguy1.MaxDefense;
            }

            //Make a funciton that displays the enemy's stats
            void DisplayEnemyStats(Enemy Badguy)
            {
                Console.WriteLine(Badguy.Name + "'s stats");
                Console.WriteLine("-------------------");
                Console.WriteLine("Handedness:" + Badguy.Handedness);
                Console.WriteLine("Health:" + Badguy.Health + "/" + Badguy.MaxHealth);
                Console.WriteLine("Damage:" + Badguy.Damage + "/" + Badguy.MaxDamage);
                Console.WriteLine("Defense:" + Badguy.Defense + "/" + Badguy.MaxDefense);
                Console.WriteLine("Mana:" + Badguy.Mana + "/" + Badguy.MaxMana);
                Console.WriteLine("Gold:" + Badguy.Gold);
                Console.WriteLine();
            }
            //Make a function that runs when the player attacks an enemy
            void PlayerAttacksEnemy(ref Enemy Attacked)
            {
                DisplayPlayerStats();
                Console.WriteLine();

                DisplayEnemyStats(Attacked);

                userChoice = GetThreeOptionInput("What would you like to do?", "1.Sword Swing", "2.Magic Missle x2DMG(10Mana)", "3.Healing Potion(25% Max Health)");
                //Player attacks with Sword Swing
                if (userChoice == 1)
                {
                    if (playerTrueDamage1 == 0)
                    {
                        Attacked.Health -= playerTrueDamage1; //Deal trueDamage
                        Console.WriteLine("Your attack deflected off the enemy!");
                        userChoice = 0; //Reset the user choice
                    }
                    else if (playerTrueDamage1 < 0)
                    {
                        Attacked.Health -= playerTrueDamage1; //Deal trueDamage
                        Console.WriteLine("You delt so little damage it healed the enemy!");
                        userChoice = 0; //Reset the user choice
                    }
                    else if (playerTrueDamage1 >= 101)
                    {
                        Attacked.Health -= playerTrueDamage1; //Deal trueDamage
                        playerMana -= 10;
                        Console.WriteLine("You turned the enemy into mist");
                        userChoice = 0; //Reset the user choice
                    }
                    else
                    {
                        Attacked.Health -= playerTrueDamage1; //Deal trueDamage
                        Console.WriteLine("You delt " + playerTrueDamage1 + " to " + Attacked.Name + "!");
                        userChoice = 0; //Reset the user choice
                    }
                }
                //Player attacks with Magic Missle
                else if (userChoice == 2)
                {
                    if (playerMagicDamage >= Attacked.Health + 101)
                    {
                        Attacked.Health -= playerMagicDamage; //Deal trueDamage
                        playerMana -= 10;
                        Console.WriteLine("You absolutely obliterate the enemy");
                        userChoice = 0; //Reset the user choice
                    }
                    else
                    {
                        Attacked.Health -= playerMagicDamage; //Deal trueDamage
                        playerMana -= 10;
                        Console.WriteLine("You delt " + playerMagicDamage + " to " + Attacked.Name + "!");
                        userChoice = 0; //Reset the user choice
                    }
                }
                //Player drinks a healing potion
                else if (userChoice == 3)
                {
                    playerHealth += potionHealAmount;
                    playerPotions -= 1;
                    Console.WriteLine("You drank the potion and healed " + potionHealAmount + " health!");
                    userChoice = 0; //Reset the user choice
                }
            }
            //Make a function that runs when an enemy attacks the player
            void EnemyAttacksPlayer(Enemy Attacker)
            {
                float attackerTrueDamage = Attacker.Damage -= Game.playerDefense;
                //If enemy does no damage
                if (attackerTrueDamage == 0)
                {
                    playerHealth -= attackerTrueDamage;
                    Console.WriteLine(Attacker.Name + "'s attack defected off of you!");
                    Console.WriteLine();
                }
                //If enemy does negative damage
                else if (attackerTrueDamage < 0)
                {
                    playerHealth -= attackerTrueDamage;
                    Console.WriteLine(Attacker.Name + " did so little damage it healed you!");
                    Console.WriteLine();
                }
                else if (attackerTrueDamage >= playerMaxHealth + 101)
                {
                    playerHealth -= attackerTrueDamage;
                    Console.WriteLine(Attacker.Name + " turned you into mist");
                    Console.WriteLine();
                }
                //If enemy does damage
                else
                {
                    playerHealth -= attackerTrueDamage;
                    Console.WriteLine(Attacker.Name + " dealt " + attackerTrueDamage + " to you!");
                    Console.WriteLine();
                }
            }
            
            bool nobodyIsDead = true;
            while (nobodyIsDead == true)
            {
                Game.DisplayPlayerStats();
                Console.WriteLine();

                DisplayEnemyStats(Badguy1);

                PlayerAttacksEnemy(ref Badguy1);

                EnemyAttacksPlayer(Badguy1);
                Console.WriteLine("Enter to continue...");
                Console.ReadLine();

                //End the battle if the enemy dies
                if (Badguy1.Health <= 0)
                {
                    Console.WriteLine("You won! The enemy " + Badguy1.Name + " has been defeated.");

                    //Give the player the Gold from the enemy
                    playerGold += Badguy1.Gold;
                    Console.WriteLine(Badguy1.Name + " dropped " + Badguy1.Gold + " gold!");

                    //Give the player the HealBarPoints from the enemy
                    playerHealBar += Badguy1.HealBarPoints;
                    Console.WriteLine(Badguy1.Name + " Increased your HealBar has increased by " + Badguy1.HealBarPoints);
                    //Apply the HealBar effect if the HealBar was maxed out
                    if (playerHealBar >= playerMaxHealBar)
                    {
                        Console.WriteLine("Your HealBar is maxed!");
                        Console.WriteLine("You have healed to full health and mana along with regaining any lost damage and defense!");
                        playerHealth = playerMaxHealth;
                        playerMana = playerMaxMana;
                        playerDamage = playerMaxDamage;
                        playerDefense = playerMaxDefense;
                        playerHealBar = 0.0f;
                    }

                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                    Game.playerWonBattle = true;
                    nobodyIsDead = false;
                }
                //End the battle if the player dies
                if (playerHealth <= 0)
                {
                    Console.WriteLine("You lost! " + Badguy1.Name + " has defeated you.");
                    Console.WriteLine("Game over");
                    Console.WriteLine("Enter to exit...");
                    Console.ReadLine();
                    Game.playerIsDead = true;
                    nobodyIsDead = false;
                    break;
                }
            }
        }
        //Make a function that runs when the battle has two enemies
        public static void PlayerGetsIntoBattle(Enemy Badguy1, Enemy Badguy2)
        {
            userChoice = 0;
            //Define enemy alive variables
            bool badGuy1Defeated = false;
            bool badGuy2Defeated = false;
            //Define player and enemies Defense
            float enemy1TrueDamage = Badguy1.Damage - playerDefense;
            float enemy2TrueDamage = Badguy2.Damage - playerDefense;
            //Define player and enemies magic attack
            float playerMagicDamage = playerDamage * 2;
            float enemy1MagicDamage = Badguy1.Damage * 2;
            float enemy2MagicDamage = Badguy2.Damage * 2;
            //Define player potion use
            float potionHealAmount = playerMaxHealth * .25f;

            //Sets Badguy1's stats to be equal to their max stats in case of randomNumber being used
            if (Badguy1.Health != Badguy1.MaxHealth || Badguy1.Damage != Badguy1.MaxDamage || Badguy1.Defense != Badguy1.MaxDefense)
            {
                Badguy1.Health = Badguy1.MaxHealth;
                Badguy1.Damage = Badguy1.MaxDamage;
                Badguy1.Defense = Badguy1.MaxDefense;
            }
            //Sets Badguy2's stats to be equal to their max stats in case of randomNumber being used
            if (Badguy2.Health != Badguy2.MaxHealth || Badguy2.Damage != Badguy2.MaxDamage || Badguy2.Defense != Badguy2.MaxDefense)
            {
                Badguy2.Health = Badguy2.MaxHealth;
                Badguy2.Damage = Badguy2.MaxDamage;
                Badguy2.Defense = Badguy2.MaxDefense;
            }
            //Gives each enemy a letter to differenciate between them if needed
            if (Badguy1.Name == Badguy2.Name)
            {
                Badguy1.Name = Badguy1.Name + "A";
                Badguy2.Name = Badguy2.Name + "B";
            }

            //Make a function that displays the enemy's stats
            void DisplayEnemyStats(Enemy Badguy)
            {
                Console.WriteLine(Badguy.Name + "'s stats");
                Console.WriteLine("-------------------");
                Console.WriteLine("Handedness:" + Badguy.Handedness);
                Console.WriteLine("Health:" + Badguy.Health + "/" + Badguy.MaxHealth);
                Console.WriteLine("Damage:" + Badguy.Damage + "/" + Badguy.MaxDamage);
                Console.WriteLine("Defense:" + Badguy.Defense + "/" + Badguy.MaxDefense);
                Console.WriteLine("Mana:" + Badguy.Mana + "/" + Badguy.MaxMana);
                Console.WriteLine("Gold:" + Badguy.Gold);
                Console.WriteLine();
            }
            //Make a function that runs when the player attacks an enemy
            void PlayerAttacksEnemy(ref Enemy Attacked)
            {
                DisplayPlayerStats();
                Console.WriteLine();

                DisplayEnemyStats(Attacked);

                userChoice = GetThreeOptionInput("What would you like to do?", "1.Sword Swing", "2.Magic Missle x2DMG(10Mana)", "3.Healing Potion(25% Max Health)");
                //Player attacks with Sword Swing
                if (userChoice == 1)
                {
                    float playerTrueDamage1 = Game.playerDamage - Attacked.Defense;
                    if (playerTrueDamage1 == 0)
                    {
                        Attacked.Health -= playerTrueDamage1; //Deal trueDamage
                        Console.WriteLine("Your attack deflected off the enemy!");
                        userChoice = 0; //Reset the user choice
                    }
                    else if (playerTrueDamage1 < 0)
                    {
                        Attacked.Health -= playerTrueDamage1; //Deal trueDamage
                        Console.WriteLine("You delt so little damage it healed the enemy!");
                        userChoice = 0; //Reset the user choice
                    }
                    else if (playerTrueDamage1 >= 101)
                    {
                        Attacked.Health -= playerTrueDamage1; //Deal trueDamage
                        playerMana -= 10;
                        Console.WriteLine("You turned the enemy into mist");
                        userChoice = 0; //Reset the user choice
                    }
                    else
                    {
                        Attacked.Health -= playerTrueDamage1; //Deal trueDamage
                        Console.WriteLine("You delt " + playerTrueDamage1 + " to " + Attacked.Name + "!");
                        userChoice = 0; //Reset the user choice
                    }
                }
                //Player attacks with Magic Missle
                else if (userChoice == 2)
                {
                    if (playerMagicDamage >= Attacked.Health + 101)
                    {
                        Attacked.Health -= playerMagicDamage; //Deal trueDamage
                        playerMana -= 10;
                        Console.WriteLine("You absolutely obliterate the enemy");
                        userChoice = 0; //Reset the user choice
                    }
                    else
                    {
                        Attacked.Health -= playerMagicDamage; //Deal trueDamage
                        playerMana -= 10;
                        Console.WriteLine("You delt " + playerMagicDamage + " to " + Attacked.Name + "!");
                        userChoice = 0; //Reset the user choice
                    }
                }
                //Player drinks a healing potion
                else if (userChoice == 3)
                {
                    playerHealth += potionHealAmount;
                    playerPotions -= 1;
                    Console.WriteLine("You drank the potion and healed " + potionHealAmount + " health!");
                    userChoice = 0; //Reset the user choice
                }
            }
            //Make a function that runs when an enemy attacks the player
            void EnemyAttacksPlayer(Enemy Attacker)
            {
                float attackerTrueDamage = Attacker.Damage -= Game.playerDefense;
                //If enemy does no damage
                if (attackerTrueDamage == 0)
                {
                    playerHealth -= attackerTrueDamage;
                    Console.WriteLine(Attacker.Name + "'s attack defected off of you!");
                    Console.WriteLine();
                }
                //If enemy does negative damage
                else if (attackerTrueDamage < 0)
                {
                    playerHealth -= attackerTrueDamage;
                    Console.WriteLine(Attacker.Name + " did so little damage it healed you!");
                    Console.WriteLine();
                }
                else if (attackerTrueDamage >= playerMaxHealth + 101)
                {
                    playerHealth -= attackerTrueDamage;
                    Console.WriteLine(Attacker.Name + " turned you into mist");
                    Console.WriteLine();
                }
                //If enemy does damage
                else
                {
                    playerHealth -= attackerTrueDamage;
                    Console.WriteLine(Attacker.Name + " dealt " + attackerTrueDamage + " to you!");
                    Console.WriteLine();
                }
            }
            
            bool nobodyIsDead = true;
            while (nobodyIsDead == true)
            {
                Game.DisplayPlayerStats();
                Console.WriteLine();

                //Display enemy stats if enemy is alive
                if (Badguy1.Health > 0)
                {
                    DisplayEnemyStats(Badguy1);
                }
                if (Badguy2.Health > 0)
                {
                    DisplayEnemyStats(Badguy2);
                }

                /// <summary>
                /// Player attacks
                /// </summary>
                if (Badguy1.Health > 0 && Badguy2.Health > 0)
                {
                    userChoice = GetTwoOptionInput("Who would you like to attack?", "1. " + Badguy1.Name, "2. " + Badguy2.Name);
                }
                //If the player attacks enemy1
                if (userChoice == 1 || Badguy2.Health <= 0)
                {
                    PlayerAttacksEnemy(ref Badguy1);
                }
                //If the player attacks enemy2
                else if (userChoice == 2 || Badguy1.Health <= 0)
                {
                    PlayerAttacksEnemy(ref Badguy2);
                }

                //If the player defeats Badguy1
                if (Badguy1.Health <= 0 && badGuy1Defeated == false)
                {
                    badGuy1Defeated = true;
                    Console.WriteLine("You defeated " + Badguy1.Name + "!");
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                }
                //If the player defeats Badguy2
                if (Badguy2.Health <= 0 && badGuy2Defeated == false)
                {
                    badGuy2Defeated = true;
                    Console.WriteLine("You defeated " + Badguy2.Name + "!");
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                }

                /// <summary>
                /// Enemy attacks
                /// </summary>
                //Both enemies attack if everone is alive (Including the player)
                if (Badguy1.Health > 0 && Badguy2.Health > 0 && playerHealth > 0)
                {
                    EnemyAttacksPlayer(Badguy1);
                    EnemyAttacksPlayer(Badguy2);
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                }
                //If only Badguy2 is dead so Badguy1 Is the only attacker
                if (Badguy1.Health > 0 && Badguy2.Health <= 0 && playerHealth > 0)
                {
                    EnemyAttacksPlayer(Badguy1);
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                }
                //If only Badguy1 is dead so Badguy2 Is the only attacker
                if (Badguy2.Health > 0 && Badguy1.Health <= 0 && playerHealth > 0)
                {
                    EnemyAttacksPlayer(Badguy2);
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                }

                /// <summary>
                /// End Battle
                /// </summary>
                //End the battle if both of the enemies dies
                if (Badguy1.Health <= 0 && Badguy2.Health <= 0)
                {
                    Console.WriteLine("You won! The enemies " + Badguy1.Name + " and " + Badguy2.Name + " has been defeated.");

                    //Give the player the Gold from the enemy
                    playerGold += Badguy1.Gold;
                    Console.WriteLine(Badguy1.Name + " dropped " + Badguy1.Gold + " gold!");
                    playerGold += Badguy2.Gold;
                    Console.WriteLine(Badguy2.Name + " dropped " + Badguy2.Gold + " gold!");

                    //Give the player the HealBarPoints from the enemy
                    playerHealBar += Badguy1.HealBarPoints;
                    playerHealBar += Badguy2.HealBarPoints;
                    Console.WriteLine(Badguy1.Name + " Increased your HealBar has increased by " + Badguy1.HealBarPoints);
                    Console.WriteLine(Badguy2.Name + " Increased your HealBar has increased by " + Badguy2.HealBarPoints);
                    //Apply the HealBar effect if the HealBar was maxed out
                    if (playerHealBar >= playerMaxHealBar)
                    {
                        Console.WriteLine("Your HealBar is maxed!");
                        Console.WriteLine("You have healed to full health and mana along with regaining any lost damage and defense!");
                        playerHealth = playerMaxHealth;
                        playerMana = playerMaxMana;
                        playerDamage = playerMaxDamage;
                        playerDefense = playerMaxDefense;
                        playerHealBar = 0.0f;
                    }

                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                    Game.playerWonBattle = true;
                    nobodyIsDead = false;
                }
                //End the battle if the player dies
                if (playerHealth <= 0)
                {
                    Console.WriteLine("You lost! " + Badguy1.Name + " and " + Badguy2.Name + " has defeated you.");
                    Console.WriteLine("Game over");
                    Console.WriteLine("Enter to exit...");
                    Console.ReadLine();
                    Game.playerIsDead = true;
                    nobodyIsDead = false;
                    break;
                }
            }
        }
        //Just a normal battle but removes the error prevention put in place for randomness
        public static void PlayerGetsIntoGlitchBattle(Enemy Badguy1)
        {
            userChoice = 0;
            //Define player and enemies basic attack
            float playerTrueDamage1 = playerDamage - Badguy1.Defense;
            float enemy1TrueDamage = Badguy1.Damage - playerDefense;
            //Define player and enemies magic attack
            float playerMagicDamage = playerDamage * 2;
            float enemy1MagicDamage = Badguy1.Damage * 2;
            //Define player potion use
            float potionHealAmount = playerMaxHealth * .25f;

            //Make a funciton that displays the enemy's stats
            void DisplayEnemyStats(Enemy Badguy)
            {
                Console.WriteLine(Badguy.Name + "'s stats");
                Console.WriteLine("-------------------");
                Console.WriteLine("Handedness:" + Badguy.Handedness);
                Console.WriteLine("Health:" + Badguy.Health + "/" + Badguy.MaxHealth);
                Console.WriteLine("Damage:" + Badguy.Damage + "/" + Badguy.MaxDamage);
                Console.WriteLine("Defense:" + Badguy.Defense + "/" + Badguy.MaxDefense);
                Console.WriteLine("Mana:" + Badguy.Mana + "/" + Badguy.MaxMana);
                Console.WriteLine("Gold:" + Badguy.Gold);
                Console.WriteLine();
            }
            //Make a function that runs when the player attacks an enemy
            void PlayerAttacksEnemy(ref Enemy Attacked)
            {
                DisplayPlayerStats();
                Console.WriteLine();

                DisplayEnemyStats(Attacked);

                userChoice = GetThreeOptionInput("What would you like to do?", "1.Sword Swing", "2.Magic Missle x2DMG(10Mana)", "3.Healing Potion(25% Max Health)");
                //Player attacks with Sword Swing
                if (userChoice == 1)
                {
                    if (playerTrueDamage1 == 0)
                    {
                        Attacked.Health -= playerTrueDamage1; //Deal trueDamage
                        Console.WriteLine("Your attack deflected off the enemy!");
                        userChoice = 0; //Reset the user choice
                    }
                    else if (playerTrueDamage1 < 0)
                    {
                        Attacked.Health -= playerTrueDamage1; //Deal trueDamage
                        Console.WriteLine("You delt so little damage it healed the enemy!");
                        userChoice = 0; //Reset the user choice
                    }
                    else if (playerTrueDamage1 >= 101)
                    {
                        Attacked.Health -= playerTrueDamage1; //Deal trueDamage
                        playerMana -= 10;
                        Console.WriteLine("You turned the enemy into mist");
                        userChoice = 0; //Reset the user choice
                    }
                    else
                    {
                        Attacked.Health -= playerTrueDamage1; //Deal trueDamage
                        Console.WriteLine("You delt " + playerTrueDamage1 + " to " + Attacked.Name + "!");
                        userChoice = 0; //Reset the user choice
                    }
                }
                //Player attacks with Magic Missle
                else if (userChoice == 2)
                {
                    if (playerMagicDamage >= Attacked.Health + 101)
                    {
                        Attacked.Health -= playerMagicDamage; //Deal trueDamage
                        playerMana -= 10;
                        Console.WriteLine("You absolutely obliterate the enemy");
                        userChoice = 0; //Reset the user choice
                    }
                    else
                    {
                        Attacked.Health -= playerMagicDamage; //Deal trueDamage
                        playerMana -= 10;
                        Console.WriteLine("You delt " + playerMagicDamage + " to " + Attacked.Name + "!");
                        userChoice = 0; //Reset the user choice
                    }
                }
                //Player drinks a healing potion
                else if (userChoice == 3)
                {
                    playerHealth += potionHealAmount;
                    playerPotions -= 1;
                    Console.WriteLine("You drank the potion and healed " + potionHealAmount + " health!");
                    userChoice = 0; //Reset the user choice
                }
            }
            //Make a function that runs when an enemy attacks the player
            void EnemyAttacksPlayer(Enemy Attacker)
            {
                float attackerTrueDamage = Attacker.Damage -= Game.playerDefense;
                //If enemy does no damage
                if (attackerTrueDamage == 0)
                {
                    playerHealth -= attackerTrueDamage;
                    Console.WriteLine(Attacker.Name + "'s attack defected off of you!");
                    Console.WriteLine();
                }
                //If enemy does negative damage
                else if (attackerTrueDamage < 0)
                {
                    playerHealth -= attackerTrueDamage;
                    Console.WriteLine(Attacker.Name + " did so little damage it healed you!");
                    Console.WriteLine();
                }
                else if (attackerTrueDamage >= playerMaxHealth + 101)
                {
                    playerHealth -= attackerTrueDamage;
                    Console.WriteLine(Attacker.Name + " turned you into mist");
                    Console.WriteLine();
                }
                //If enemy does damage
                else
                {
                    playerHealth -= attackerTrueDamage;
                    Console.WriteLine(Attacker.Name + " dealt " + attackerTrueDamage + " to you!");
                    Console.WriteLine();
                }
            }

            bool nobodyIsDead = true;
            while (nobodyIsDead == true)
            {
                Game.DisplayPlayerStats();
                Console.WriteLine();

                DisplayEnemyStats(Badguy1);

                PlayerAttacksEnemy(ref Badguy1);

                EnemyAttacksPlayer(Badguy1);
                Console.WriteLine("Enter to continue...");
                Console.ReadLine();

                //End the battle if the enemy dies
                if (Badguy1.Health <= 0)
                {
                    Console.WriteLine("You won! The enemy " + Badguy1.Name + " has been defeated.");

                    //Give the player the Gold from the enemy
                    playerGold += Badguy1.Gold;
                    Console.WriteLine(Badguy1.Name + " dropped " + Badguy1.Gold + " gold!");

                    //Give the player the HealBarPoints from the enemy
                    playerHealBar += Badguy1.HealBarPoints;
                    Console.WriteLine(Badguy1.Name + " Increased your HealBar has increased by " + Badguy1.HealBarPoints);
                    //Apply the HealBar effect if the HealBar was maxed out
                    if (playerHealBar >= playerMaxHealBar)
                    {
                        Console.WriteLine("Your HealBar is maxed!");
                        Console.WriteLine("You have healed to full health and mana along with regaining any lost damage and defense!");
                        playerHealth = playerMaxHealth;
                        playerMana = playerMaxMana;
                        playerDamage = playerMaxDamage;
                        playerDefense = playerMaxDefense;
                        playerHealBar = 0.0f;
                    }

                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                    Game.playerWonBattle = true;
                    nobodyIsDead = false;
                }
                //End the battle if the player dies
                if (playerHealth <= 0)
                {
                    Console.WriteLine("You lost! " + Badguy1.Name + " has defeated you.");
                    Console.WriteLine("Game over");
                    Console.WriteLine("Enter to exit...");
                    Console.ReadLine();
                    Game.playerIsDead = true;
                    nobodyIsDead = false;
                    break;
                }
            }
        }

        //Make a function that allows the player to define their stats
        public static void DefinePlayerStatsNGPlus()
        {
            int statChoice = 0;
            //Make a function to get a number
            static int GetNumber(string description)
            {
                string input = "";
                int numberInput = 0;
                bool noNumberSelected = true;

                // Input loop
                while (noNumberSelected == true)
                {
                    DisplayPlayerStats();
                    Console.WriteLine(description);
                    Console.WriteLine("Type a number");
                    Console.Write("> ");

                    // Get input from player
                    // I had to use some things i dont fully understand to get this to work :[
                    input = Console.ReadLine();
                    try
                    {
                        numberInput = Convert.ToInt32(input);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That is not a number");
                    }
                    catch (OverflowException)
                    {
                        FakeCrash();
                        Console.Clear();
                        Thread.Sleep(5000);
                        Console.WriteLine("ERROR Failed to end debugging trying again");
                        Console.WriteLine(".");
                        Thread.Sleep(2000);
                        Console.WriteLine(".");
                        Thread.Sleep(2000);
                        Console.WriteLine(".");
                        Thread.Sleep(2000);
                        Console.WriteLine(".");
                        Thread.Sleep(2000);
                        Console.WriteLine(".");
                        Thread.Sleep(2000);
                        Enemy RAM = new Enemy(Name: "Downloaded RAM", Handedness: "ERROR", MaxHealth: 0, Health: 666, MaxMana: 0, Mana: 666, MaxDamage: 0, Damage: 666, MaxDefense: 0, Defense: 666, HealBarPoints: 0, Gold: 0);
                        PlayerGetsIntoGlitchBattle(RAM);
                        return 322122578;
                    }
                    // When the player chooses their stat count
                    if (numberInput >= 1 && numberInput <= 665)
                    {
                        noNumberSelected = false;
                    }

                    // If the player chooses an input too high or is negative
                    else if (numberInput < 0 || numberInput > 665)
                    {
                        FakeCrash();
                        Console.Clear();
                        Thread.Sleep(5000);
                        Console.WriteLine("ERROR Failed to end debugging trying again");
                        Console.WriteLine(".");
                        Thread.Sleep(2000);
                        Console.WriteLine(".");
                        Thread.Sleep(2000);
                        Console.WriteLine(".");
                        Thread.Sleep(2000);
                        Console.WriteLine(".");
                        Thread.Sleep(2000);
                        Console.WriteLine(".");
                        Thread.Sleep(2000);
                        Enemy RAM = new Enemy(Name: "Downloaded RAM", Handedness: "ERROR", MaxHealth: 0, Health: 666, MaxMana: 0, Mana: 666, MaxDamage: 0, Damage: 666, MaxDefense: 0, Defense: 666, HealBarPoints: 0, Gold: 0);
                        PlayerGetsIntoGlitchBattle(RAM);
                        return 322122578;
                    }

                    // If neither are true
                    else
                    {
                        // Display error message
                        Console.WriteLine("Invalid Input");
                        Console.ReadKey();
                    }
                }
                return numberInput;
                Console.Clear();
            }

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
            Console.WriteLine("You will now choose your stats");
            Console.WriteLine("WARNING SELECTING A NUMBER TOO HIGH OR A NON-POSITIVE NUMBER WILL RESULT IN DIRE CONSEQUENSES");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You will now choose 666 stats");
            Console.WriteLine("WARNING SELECTING A POSITIVE NUMBER BELOW (666) WILL RESULT IN DIRE CONSEQUENSES");
            Thread.Sleep(10);
            Console.Clear();

            //Get playerHealBar Value
            statChoice = GetNumber("What would you like your starting HealBar to be? (TYPE A NUMBER)");
            if (statChoice == 322122578)
            {
                return;
            }
            playerHealBar = statChoice;
            //Get playerMaxHealBar Value
            statChoice = GetNumber("What would you like your starting MaxHealBar to be? (TYPE A NUMBER)");
            if (statChoice == 322122578)
            {
                return;
            }
            playerMaxHealBar = statChoice;

            //Get playerMaxHealth Value
            statChoice = GetNumber("What would you like your starting MaxHealth to be? (TYPE A NUMBER)");
            if (statChoice == 322122578)
            {
                return;
            }
            playerMaxHealth = statChoice;
            //Get playerHealth Value
            statChoice = GetNumber("What would you like your starting Health to be? (TYPE A NUMBER)");
            if (statChoice == 322122578)
            {
                return;
            }
            playerHealth = statChoice;

            //Get playerMaxMana Value
            statChoice = GetNumber("What would you like your starting MaxMana to be? (TYPE A NUMBER)");
            if (statChoice == 322122578)
            {
                return;
            }
            playerMaxMana = statChoice;
            //Get playerMana Value
            statChoice = GetNumber("What would you like your starting Mana to be? (TYPE A NUMBER)");
            if (statChoice == 322122578)
            {
                return;
            }
            playerMana = statChoice;

            //Get playerMaxDamage Value
            statChoice = GetNumber("What would you like your starting MaxDamage to be? (TYPE A NUMBER)");
            if (statChoice == 322122578)
            {
                return;
            }
            playerMaxDamage = statChoice;
            //Get playerDamage Value
            statChoice = GetNumber("What would you like your starting Damage to be? (TYPE A NUMBER)");
            if (statChoice == 322122578)
            {
                return;
            }
            playerDamage = statChoice;

            //Get playerMaxDefense Value
            statChoice = GetNumber("What would you like your starting MaxDefense to be? (TYPE A NUMBER)");
            if (statChoice == 322122578)
            {
                return;
            }
            playerMaxDefense = statChoice;
            //Get playerDefense Value
            statChoice = GetNumber("What would you like your starting Defense to be? (TYPE A NUMBER)");
            if (statChoice == 322122578)
            {
                return;
            }
            playerDefense = statChoice;

            //Get playerPotions Value
            statChoice = GetNumber("What would you like your starting PotionCount to be? (TYPE A NUMBER)");
            if (statChoice == 322122578)
            {
                return;
            }
            playerPotions = statChoice;
            //Get playerMaxPotions Value
            statChoice = GetNumber("What would you like your starting MaxPotionCount to be? (TYPE A NUMBER)");
            if (statChoice == 322122578)
            {
                return;
            }
            playerMaxPotions = statChoice;

            //Get playerGold Value
            statChoice = GetNumber("What would you like your starting Gold Count to be? (TYPE A NUMBER)");
            if (statChoice == 322122578)
            {
                return;
            }
            playerGold = statChoice;

            //Do certian things to the players stats if their name is something specific
            if (playerName == "Bobligiferous The Twost")
            {
                playerGold += 500;
            }
            if (playerName == "Boblious" || playerName == "boblious")
            {
                playerDamage += 15;
                playerMaxDamage += 15;
            }
            if (playerName == "Sodakin")
            {
                playerPotions += 10;
                playerMaxPotions += 10;
            }
            //Subtract player damage by 1 if they are Ambidexterious 
            if (playerHandedness == ("Ambidexterous"))
            {
                playerDamage -= 1;
                playerMaxDamage -= 1;
            }
        }

        /// <summary>
        /// Start game
        /// </summary>
        public void Run()
        {
            DefinePlayerStats();
            Game.currentArea = 0;
            Console.WriteLine("HelloDungeon says Hello, " + Game.playerName + ".");
            Console.WriteLine("Enter to continue...");
            Console.ReadLine();
            //Keeps the game loop
            while (Game.gameOver == false)
            {
                //Area 1 Statue and Corridor
                if (Game.currentArea == 1 && Game.playerOnNGPlus == false)
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
                
                //Area 2 Goblin fight
                if (Game.currentArea == 2 && Game.playerOnNGPlus == false)
                {
                    Game.DisplayPlayerStats();
                    Console.WriteLine("After a while you awake again");
                    Console.WriteLine("You look around");
                    Console.ReadLine();

                    Game.DisplayPlayerStats();
                    Console.WriteLine("Unlike before this area is well lit");
                    Console.WriteLine("You can see a group of goblins");
                    Console.ReadKey();
                    Enemy goblin = new Enemy(Name: "Goblin", Handedness: "Left", MaxHealth: randomNumber.Next(8, 12), Health: 0, MaxMana: 0, Mana: 0, MaxDamage: randomNumber.Next(4, 6), Damage: 0, MaxDefense: randomNumber.Next(0, 1), Defense: 0, HealBarPoints: randomNumber.Next(3, 6), Gold: randomNumber.Next(47, 86));
                    PlayerGetsIntoBattle(goblin, goblin);
                    Console.WriteLine("A chest appears in front of you");
                    Console.WriteLine("It looks like its been through a lot");
                    Console.WriteLine("Stabs and scratches all over, the goblins must have tryed to pry it open");
                    userChoice = GetTwoOptionInput("Open it?", "1. Open", "2. Don't Open");
                    //If the player opens the chest (its a mimic lol)
                    if (userChoice == 1)
                    {
                        Enemy mimic = new Enemy(Name: "Mimic", Handedness: "Ambidexterious", MaxHealth: 100, Health: 72, MaxMana: 10, Mana: 10, MaxDamage: 5, Damage: 5, MaxDefense: 2, Defense: 2, HealBarPoints: 10, Gold: 1000);
                        PlayerGetsIntoBattle(mimic);
                        Console.WriteLine("There is nowhere else to go.");
                        Console.WriteLine("You leave the dungeon.");
                        Game.gameOver = true;
                    }
                    //If the player doesnt open the chest
                    if (userChoice == 2)
                    {
                        Console.WriteLine("There is nowhere else to go.");
                        Console.WriteLine("You leave the dungeon.");
                        Game.gameOver = true;
                    }
                }

                //NG+ Area 1 Statue and Corridor
                if (Game.currentArea == 1 && Game.playerOnNGPlus == true)
                {
                    //Corridor or Statue Area
                    Game.DefinePlayerStatsNGPlus();
                    //Actually start the game intro thingy
                    Console.Clear();
                    Console.WriteLine("HelloDungeon says Hello, " + Game.playerName + ".");
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                    Game.DisplayPlayerStats();
                    Console.WriteLine(Game.playerName + ", you find yourself plundering an unexplored dungeon... again");
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

                //NG+ Area 2 Goblin fight
                if (Game.currentArea == 2 && Game.playerOnNGPlus == true)
                {
                    Game.DisplayPlayerStats();
                    Console.WriteLine("After a while you awake again");
                    Console.WriteLine("You look around");
                    Console.ReadLine();

                    Game.DisplayPlayerStats();
                    Console.WriteLine("Unlike before this area is well lit");
                    Console.WriteLine("You can see a group of goblins");
                    Console.ReadKey();
                    Enemy goblin = new Enemy(Name: "Goblin", Handedness: "Left", MaxHealth: randomNumber.Next(8, 12), Health: 0, MaxMana: 0, Mana: 0, MaxDamage: randomNumber.Next(4, 6), Damage: 0, MaxDefense: randomNumber.Next(0, 1), Defense: 0, HealBarPoints: randomNumber.Next(3, 6), Gold: randomNumber.Next(47, 86));
                    PlayerGetsIntoBattle(goblin, goblin);
                    if (playerIsDead == false)
                    {
                        Console.WriteLine("A chest appears in front of you");
                        Console.WriteLine("It looks like its been through a lot");
                        Console.WriteLine("Stabs and scratches all over, the goblins must have tryed to pry it open");
                        userChoice = GetTwoOptionInput("Open it?", "1. Open", "2. Don't Open");
                        //If the player opens the chest (its a mimic lol)
                        if (userChoice == 1)
                        {
                            Enemy mimic = new Enemy(Name: "Mimic", Handedness: "Ambidexterious", MaxHealth: 100, Health: 72, MaxMana: 10, Mana: 10, MaxDamage: 5, Damage: 5, MaxDefense: 2, Defense: 2, HealBarPoints: 10, Gold: 1000);
                            PlayerGetsIntoBattle(mimic);
                            if (playerIsDead == false)
                            {
                                Console.WriteLine("There is nowhere else to go.");
                                Console.WriteLine("You leave the dungeon.");
                                Game.gameOver = true;
                            }
                        }
                        //If the player doesnt open the chest
                        if (userChoice == 2)
                        {
                            Console.WriteLine("There is nowhere else to go.");
                            Console.WriteLine("You leave the dungeon.");
                            Game.gameOver = true;
                        }
                    }
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

                if (gameOver == true)
                {
                    Console.WriteLine("GAME END");
                    Game.userChoice = GetTwoOptionInput("Would you like to play again? (There is a NG+ lmao)", "Yes", "No");
                    if (Game.userChoice == 1)
                    {
                        playerOnNGPlus = true;
                        gameOver = false;
                        Game.playerIsDead = false;
                        Game.currentArea = 0;
                    }
                    if (Game.userChoice == 2)
                    {

                    }
                }
            }
            Console.WriteLine("HelloDungeon says goodbye");
            Console.ReadKey();
        }
    }
}