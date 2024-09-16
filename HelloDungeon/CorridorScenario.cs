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
            //Result of entering the corridor
            Game.DisplayPlayerStats();
            Console.WriteLine("");
            Console.WriteLine("You approach the corridor as you enter you feel a cold breeze.");
            Console.WriteLine("You feel your way through the corridor.");
            Console.WriteLine("The walls are slimy and sting to touch.");
            Console.WriteLine("");
            Console.WriteLine("After walking for a few minutes your hand feels a stick of wood attached to the wall");
            Console.WriteLine("Its an unlit torch");
            Console.WriteLine("");

            //Trapped torch choice
            Game.userChoice = Game.GetTwoOptionInput("Take it?", "Take", "Ignore");

            //Sets returned to false so that if the player ignored the torch they can return
            bool returned = false; 

            //The loop for the torch choice
            for (int i=0; i<1; i++)
            {
                //If Taking the Torch
                if (Game.userChoice == 1)
                {
                    //Result of taking the torch
                    Game.DisplayPlayerStats();
                    Console.WriteLine("");
                    Console.WriteLine("You attempt to pull the torch off the wall.");
                    Console.WriteLine("It comes off as you hear a click.");
                    Console.WriteLine("The floor falls out under you and you are knocked unconscious upon landing.");
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                    Game.userChoice = 0; //Reset the user choice
                    break;
                }

                //Ignoring the Torch for the first time
                if (Game.userChoice == 2 && returned == false)
                {
                    //Result of not taking the torch
                    Game.DisplayPlayerStats();
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
                        Console.WriteLine("(-3 Health) (-2 Attack)");
                    }

                    //Only subtract from the players health if they aren't right handed
                    else
                    {
                        Game.playerHealth -= 3;
                        Console.WriteLine("(-3 Health)");
                    }
                    
                    //Player returns to the torch after taking damage
                    Console.WriteLine("You run back to the torch");
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                    returned = true;

                    //Reset the user choice
                    Game.userChoice = 0; 
                }

                //When they return if they ignored the torch the first time
                if (returned == true)
                {
                    Game.DisplayPlayerStats();
                    Console.WriteLine("Your back at the torch");

                    //Trapped torch choice 2 electric boogaloo
                    Game.userChoice = Game.GetTwoOptionInput("Take it?", "Type 1: Take", "Type 2: Return to confront statue");
                }

                //Ignoring the torch for the second time and returning to statue
                if (Game.userChoice == 2 && returned == true)
                {
                    Game.DisplayPlayerStats();
                    Console.WriteLine("You decide to ignore the torch again and head back to confront the statue");
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();

                    //Sends player to StatueScenario
                    StatueScenario statueScenario = new StatueScenario();
                    statueScenario.Run();
                    break;
                }

                //Decreased i in the for loop to keep it looping if they dont choose a valid option
                if (Game.userChoice != 1 && Game.userChoice != 2)
                {
                    i--;
                }
            }

        }
    }
}
