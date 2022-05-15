using System;
using static System.Console;

namespace JordansGTAClone
{
    class Mission
    {
        public static void Dialog(Player PLAYER, string mission)
        {
            switch (mission)
            {
                //GAME INTRO DIALOG
                case "intro":
                    Display.TextColour("narratorWrite", "Narrator: You have just left Glendale prison after serving 9 and a half years for armed robbery. ");
                    Thread.Sleep(4500);
                    Display.TextColour("narratorWriteLine", "You have nothing to your name so must make money by carrying out assignments for underworld bosses you met in the past. \n");
                    Thread.Sleep(6000);
                    Display.TextColour("narratorWriteLine", $"Narrator: You have been given {PLAYER.CREDITS} credits to get you started! \n");
                    Thread.Sleep(3000);
                    break;

                case "1":
                    //MISSION 1 - QUAY SIDE - DIALOG
                    Display.TextColour("narratorWriteLine", "Narrator: Your first assignment is to get across the city to Quay Side and meet with an old friend, Tony. I have called you a cab at a cost of 20 credits.\n");
                    Thread.Sleep(6000);
                    Display.TextColour("narratorWriteLine", "Your cab is on its way ... ");
                    Thread.Sleep(1000);
                    Display.Loading(350);
                    Logic.InCab(20, "QUAY SIDE", PLAYER);
                    Thread.Sleep(2000);
                    Display.TextColour("tony", "Tony: I need your help picking up a package, it's located across the street from us in that building over there (points). There's a few guys in there who will fight back. You'll need a weapon, don't worry i'm fully stocked. \n");
                    Thread.Sleep(10000);
                    Display.TextColour("tony", "Tony: For your efforts I will split my profits with you.. lets say 70/30.. I'll take my cut and will pay you a cut of 125 credits. Sound good ? \n");
                    Thread.Sleep(8000);
                    break;

                case "2":
                    //MISSION 2 DIALOG
                    break;


                default:
                    //for debugging only
                    WriteLine("OUT OF RANGE");
                    break;
            }
        }
        public static void CompleteMission(Weapon[] WEAPONS, Player PLAYER, string mission)
        {
            switch (mission)
            {
                //Mission 1 - QUAY SIDE
                //CREDITS + 125
                //HEALTH - 2
                //WANTED LEVEL + 1
                case "1":
                    WriteLine("Here are your earnings as promised.");
                    Thread.Sleep(1000);
                    WriteLine($"Mission Completed. +125 Credits earned.");
                    Thread.Sleep(1000);
                    PLAYER.IncreaseCredits(125);
                    Thread.Sleep(1000);
                    PLAYER.DecreaseHealthArmour(2);
                    //check if wasted after health/armour hit
                    Logic.IsWasted(PLAYER);
                    Thread.Sleep(1000);
                    PLAYER.WantedLevelUp(1);
                    Thread.Sleep(2000);
                    PLAYER.Stats();
                    Thread.Sleep(2000);
                    Display.Map("QUAY SIDE");
                    Display.TextColour("tony", $"Tony: Congratulations on passing your first mission {PLAYER.PLAYER_NAME}. You are now free to do as you please until i contact you with more work.");
                    Display.Loading(250);
                    break;

                default:
                    //for debugging only
                    WriteLine("OUT OF RANGE");
                    break;

            }
        }
    }
}
