﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon 
{
    //Makes the variables for enemy stats
    public struct Enemy
    {
        public string Handedness;
        public float MaxHealth;
        public float Health;
        public float MaxMana;
        public float Mana;
        public float MaxDamage;
        public float Damage;
        public float Defense;
        public float MaxDefense;
        public int Gold;

        public Enemy(
            string Handedness,
            float MaxHealth,
            float Health,
            float MaxMana,
            float Mana,
            float MaxDamage,
            float Damage,
            float MaxDefense,
            float Defense,
            int Gold
            )
        {
            this.Handedness = Handedness;
            this.MaxHealth = MaxHealth;
            this.Health = Health;
            this.MaxMana = MaxMana;
            this.Mana = Mana;
            this.MaxDamage = MaxDamage;
            this.Damage = Damage;
            this.MaxDefense = MaxDefense;
            this.Defense = Defense;
            this.Gold = Gold;

        }
    }

    internal class Game
    {
        public static int userChoice;
        public static string playerName;

        //Makes the variables for the player's stats
        public static string playerHandedness;
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

        //Make a function that displays players current stats
        public static void DisplayPlayerStats()
        {
            Console.Clear();
            Console.WriteLine(playerName + "'s stats");
            Console.WriteLine("-------------------");
            Console.WriteLine("Handedness:" + Game.playerHandedness);
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
            while (nobodyIsDead == true)
            {
                bool nobodyIsDead = true;
                float playerTrueDamage = playerDamage -= Badguy.Defense;
                float playerMagicDamage = playerDamage*2;
                float enemyTrueDamage = playerDamage -= playerDefense;
                float enemyMagicDamage = playerDamage * 2;

                Game.DisplayPlayerStats();
                Console.WriteLine();

                Console.WriteLine("Enemy's stats");
                Console.WriteLine("-------------------");
                Console.WriteLine("Handedness:" + Badguy.Handedness);
                Console.WriteLine("Health:" + Badguy.Health + "/" + Badguy.MaxHealth);
                Console.WriteLine("Damage:" + Badguy.Damage + "/" + Badguy.MaxDamage);
                Console.WriteLine("Defense:" + Badguy.Defense + "/" + Badguy.MaxDefense);
                Console.WriteLine("Mana:" + Badguy.Mana + "/" + Badguy.MaxMana);
                Console.WriteLine("Gold:" + Badguy.Gold);
                Console.WriteLine();
                userChoice = GetThreeOptionInput("What would you like to do?", "1.Sword Swing", "2.Magic Missle(10Mana)", "3.Healing Potion?");
                //Player attacks with Sword Swing
                if (userChoice == 1)
                {
                    Badguy.Health -= playerTrueDamage; //Deal trueDamage
                    Console.WriteLine("You delt " + playerTrueDamage +" to the enemy!");
                    userChoice = 0; //Reset the user choice
                }
                //Player attacks with Magic Missle
                else if (userChoice == 2)
                {
                    Badguy.Health -= playerMagicDamage; //Deal trueDamage
                    Console.WriteLine("You delt " + playerMagicDamage + " to the enemy!");
                    userChoice = 0; //Reset the user choice
                }
                //Player drinks a healing potion
                else if (userChoice == 3)
                {
                    //FINISH HEREEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
                    userChoice = 0; //Reset the user choice
                }

                //Enemy attacks
                if (Badguy.Health > 0 && playerHealth > 0)
                {
                    playerHealth -= playerTrueDamage; //Deal trueDamage
                    Console.WriteLine("The enemy dealt " + playerTrueDamage + " to you!");
                }

                //End the battle if someone dies
                if (Badguy.Health == 0 || playerHealth == 0)
                {
                    nobodyIsDead = false;
                }
            }
        }

        public void Run()
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
            //Subtract player damage by 1 if they are Ambidexterious 
            if (playerHandedness == ("Ambidexterous"))
            {
                playerDamage -= 1;
                playerMaxDamage -= 1;
            }

            //Intro thingy
            Console.Clear();
            Console.WriteLine("HelloDungeon says hi, " + playerName + ".");
            Console.WriteLine("Enter to continue...");
            Console.ReadLine();

            //Corridor or Statue choice
            Game.DisplayPlayerStats();
            Console.WriteLine( playerName + ", you find yourself plundering an unexplored dungeon");
            userChoice = GetTwoOptionInput("Do you approach the ominous dark corridor or the odd statue guarding a door?", "Corridor", "Statue");
            if (userChoice == 1)
            {
                CorridorScenario corridorScenario = new CorridorScenario();
                corridorScenario.Run();
                userChoice = 0; //Reset the user choice

            } //Send player to CorridorScenario
            if (userChoice == 2)
            {
                StatueScenario statueScenario = new StatueScenario();
                statueScenario.Run();
                userChoice = 0; //Reset the user choice
            } //Send player to StatueScenario

            Game.DisplayPlayerStats();
            Console.WriteLine("END OF CORRIDOR AND STATUE SCENARIOS");

            

        }
    }
}
