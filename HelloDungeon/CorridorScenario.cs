using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    internal class CorridorScenario
    {
        public static bool tookTorch;
        public static bool returned;


        public void Run()
        {
            //Display player current stats
            Console.Clear();
            Console.WriteLine("Handedness:" + Game.playerHandedness);
            Console.WriteLine("Health:" + Game.playerHealth);
            Console.WriteLine("Damage:" + Game.playerDamage); 
            Console.WriteLine("Mana:" + Game.playerMana);
            Console.WriteLine("Gold:" + Game.playerGold);


            //Result of entering the corridor and Trapped Torch choice
            Console.WriteLine("");
            Console.WriteLine("You approach the corridor as you enter you feel a cold breeze.");
            Console.WriteLine("You feel your way through the corridor.");
            Console.WriteLine("The walls are slimy and sting to touch.");
            Console.WriteLine("");
            Console.WriteLine("After walking for a few minutes your hand feels a stick of wood attached to the wall");
            Console.WriteLine("Its an unlit torch");
            Console.WriteLine("");
            Console.WriteLine("Take it?");
            while (Game.userChoice != "1" && Game.userChoice != "2")
            {
                Console.WriteLine("Type 1: Take | Type 2: Ignore");
                Game.userChoice = Console.ReadLine();
            }

            bool returned = false; // sets returned to false so that if the player ignores the torch they can return
            for (int i=0; i<1; i++)
            {

                if (returned == true)
                {
                    while (Game.userChoice != "1" && Game.userChoice != "2")
                    {
                        Console.Clear();
                        Console.WriteLine("Handedness:" + Game.playerHandedness);
                        Console.WriteLine("Health:" + Game.playerHealth);
                        Console.WriteLine("Damage:" + Game.playerDamage);
                        Console.WriteLine("Mana:" + Game.playerMana);
                        Console.WriteLine("Gold:" + Game.playerGold);
                        Console.WriteLine();
                        Console.WriteLine("Your back at the torch");
                        Console.WriteLine("Type 1: Take | Type 2: Return to confront statue");
                        Game.userChoice = Console.ReadLine();
                    }
                }
                //Taking the Torch
                if (Game.userChoice == "1")
                {
                    //Display player current stats
                    Console.Clear();
                    Console.WriteLine("Handedness:" + Game.playerHandedness);
                    Console.WriteLine("Health:" + Game.playerHealth);
                    Console.WriteLine("Damage:" + Game.playerDamage);
                    Console.WriteLine("Mana:" + Game.playerMana);
                    Console.WriteLine("Gold:" + Game.playerGold);

                    //Result of taking the torch
                    Console.WriteLine("");
                    Console.WriteLine("You attempt to pull the torch off the wall.");
                    Console.WriteLine("It comes off as you hear a click.");
                    tookTorch = true;
                    Console.WriteLine("The floor falls out under you and you are knocked unconcious upon landing.");
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();

                    Game.userChoice = "0"; //Reset the user choice

                    break;
                }

                //Ignoring the Torch
                if (Game.userChoice == "2" && returned == false)
                {
                    //Display player current stats
                    Console.Clear();
                    Console.WriteLine("Handedness:" + Game.playerHandedness);
                    Console.WriteLine("Health:" + Game.playerHealth);
                    Console.WriteLine("Damage:" + Game.playerDamage);
                    Console.WriteLine("Mana:" + Game.playerMana);
                    Console.WriteLine("Gold:" + Game.playerGold);

                    //Result of not taking the torch
                    Console.WriteLine("");
                    Console.WriteLine("You ignore it, it could be a trap anyways.");
                    Console.WriteLine("You continue forward when your right hand is suddenly sucked into something");
                    Console.WriteLine("It starts burning immensly");
                    Console.WriteLine("You quickly pull your hand back");
                    Console.WriteLine("Your right hand is now injured");

                    //Reduces the players damage if they are right handed and Health due to the injured right hand
                    if (Game.playerHandedness == "Right")
                    {
                        Game.playerDamage -= 2;
                        Game.playerHealth -= 3;
                        Console.WriteLine("(-3 Health) (-1 Attack)");
                        Console.WriteLine("You run back to the torch");
                        returned = true;
                        Console.WriteLine("Enter to continue...");
                        Console.ReadLine();
                        returned = true;
                    }
                    else
                    {
                        Game.playerHealth -= 3;
                        Console.WriteLine("(-3 Health)");
                        Console.WriteLine("You run back to the torch");
                        returned = true;
                        Console.WriteLine("Enter to continue...");
                        Console.ReadLine();
                    }

                    Game.userChoice = "0"; //Reset the user choice


                }
                if (Game.userChoice == "2" && returned == true)
                {
                    Console.Clear();
                    Console.WriteLine("Handedness:" + Game.playerHandedness);
                    Console.WriteLine("Health:" + Game.playerHealth);
                    Console.WriteLine("Damage:" + Game.playerDamage);
                    Console.WriteLine("Mana:" + Game.playerMana);
                    Console.WriteLine("Gold:" + Game.playerGold);
                    Console.WriteLine();
                    Console.WriteLine("You decide to ignore the torch again and head back to confront the statue");
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                    StatueScenario statueScenario = new StatueScenario();
                    statueScenario.Run();
                }
                if (Game.userChoice != "1" && Game.userChoice != "2")
                {
                    i--;
                }

                
            }

        }
    }
}
