using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon 
{
    internal class Game
    {
        public static string playerHandedness;
        public static int userChoice;
        public static float maxPlayerHealth;
        public static float playerHealth;
        public static float maxPlayerMana;
        public static float playerMana;
        public static float maxPlayerDamage;
        public static float playerDamage;
        public static int playerGold;

        // Make a function that displays players current stats
        public static void DisplayPlayerStats()
        {
            Console.Clear();
            Console.WriteLine("Handedness:" + Game.playerHandedness);
            Console.WriteLine("Health:" + Game.playerHealth + "/" + Game.maxPlayerHealth);
            Console.WriteLine("Damage:" + Game.playerDamage + "/" + Game.maxPlayerDamage);
            Console.WriteLine("Mana:" + Game.playerMana + "/" + Game.maxPlayerMana);
            Console.WriteLine("Gold:" + Game.playerGold);
            Console.WriteLine();
        }
        
        // Make a function for a two choice option
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

        // Make a function for a three choice option
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


        public void Run()
        {
            //Get the players name
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            Console.Clear();

            // Get playerHandedness
            userChoice = GetThreeOptionInput("Ok " + playerName + " what is your dominant hand?", "Left Handed", "Right Handed", "Ambidexterous");            
            //Set player handedness to left
            if (userChoice == 1)
            {
                playerHandedness = ("Left");
                userChoice = 0; //Reset the user choice
            }
            //Set player handedness to right
            if (userChoice == 2)
            {
                playerHandedness = ("Right");
                userChoice = 0; //Reset the user choice
            }
            //Set player handedness to ambidexterous
            if (userChoice == 3)
            {
                playerHandedness = ("Ambidexterous");
                userChoice = 0; //Reset the user choice
            }

            // Set the players stats
            maxPlayerHealth = 20.0f;
            playerHealth = 20.0f;
            maxPlayerMana = 50.0f;
            playerMana = 50.0f;
            maxPlayerDamage = 5.0f;
            playerDamage = 5.0f;
            playerGold = 50;
            // Do certian things to the players stats if their name is something specific
            if (playerName == "Bobligiferous The Twost")
            {
                playerGold = 500;
            }
            if (playerName == "Boblious" || playerName == "boblious")
            {
                playerDamage = 20;
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
