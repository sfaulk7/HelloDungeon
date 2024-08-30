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
            //Result of approaching the statue
            Game.DisplayPlayerStats();
            Console.WriteLine();
            Console.WriteLine("The statue is tall and clad in gilded armour. It lloks like a king.");
            Console.WriteLine("There is a sign next to it. It reads:");
            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                //The riddle the player has to solve
                if (i < 4)
                {
                    Console.WriteLine("I was king for years to pass");
                    Console.WriteLine("Head of a circle though even with the sides of brass");
                    Console.WriteLine("More worthy than the stone, surpassed");
                    Console.WriteLine("Ruled with my love but with her betrayal, chaos was the forecast");
                    Console.WriteLine("Recite my name and you may pass");
                }

                //If the player fails the riddle 4 times
                else if (i == 4)
                {
                    Console.WriteLine("The statue starts to move and speaks with a booming voice");
                    Console.WriteLine("I am king of camelot");
                    Console.WriteLine("Head of the knights of the roundtable");
                    Console.WriteLine("Pulled the legendary sword Excaliber from its stone resting place");
                    Console.WriteLine("Ruled with Guinevere but her affair with Lancelot brough chaos");
                    Console.WriteLine("Recite my name and you may pass");
                }

                //If the player fails the riddle 5 times WILL COME BACK TO THIS AFTER THE REST OF THE ENCOUNTER IS FINISHED
                //else if (i == 5)
                //{
                //Console.WriteLine("The statue unsheaths its sword and speaks with a booming voice");
                //Console.WriteLine("I am king of camelot");
                //Console.WriteLine("Head of the knights of the roundtable");
                //Console.WriteLine("Pulled the legendary sword Excaliber from its stone resting place");
                //Console.WriteLine("Ruled with Guinevere but her affair with Lancelot brough chaos");
                //Console.WriteLine("I am King Arthur of camelot");
                //Console.WriteLine("The statue attacks!");
                //}

                //When the player makes their guess
                string riddleChoice = Console.ReadLine();

                //If the player gets the riddle correct
                if (riddleChoice == "Arthur" || riddleChoice == "arthur" || riddleChoice == "ARTHUR")
                {
                    Console.WriteLine("Correct, you may pass.");
                    Console.WriteLine("The statue steps aside and opens the huge iron door behind it");
                    Console.WriteLine("You go through the door and down the steps through it");
                    break;
                }
            }
        }
    }
}
