using System;
using static System.Console;

namespace JordansGTAClone
{
    class Logic
    {
        //INCOMING CALLS - uint call refers to call type. See switch block
        public static void IncomingCall(Player PLAYER, uint callType)
        {
            WriteLine("  __ |  zzz");
            WriteLine(" |---|");
            WriteLine(" |[_]| zzz");
            WriteLine(" |:::|");
            WriteLine(" |:::|");
            WriteLine(@" \   \  zzz");
            WriteLine(@"  \_=_\");
            WriteLine("\n");
            WriteLine("Incoming call from Tony. Press 'Y' to accept or 'N' to decline.");
            //take player response and convert to uppercase
            string rawResponse = ReadLine();
            string response = rawResponse.ToUpper();

            //take player response again until Y or N is entered
            while (response != "Y" && response != "N")
            {
                WriteLine("Please respond with 'Y' or 'N' only..");
                rawResponse = ReadLine();
                response = rawResponse.ToUpper();
            }

            //logic for PLAYER response 
            if (response == "Y")
            {
                WriteLine("Call Accepted.");
                Thread.Sleep(2000);
                switch (callType)
                {
                    //1 = play cards with Tony
                    case 1:
                        WriteLine($"Tony: {PLAYER.PLAYER_NAME}, lets play some cards, come over to my place in Ashdale, I've already paid for your cab.");
                        Display.Loading(250);
                        InCab(0, "ASHDALE", PLAYER);
                        PlayCards.Start(PLAYER);
                        break;
                    //2 = mission in Cottleton Woods
                    case 2:
                        WriteLine("Call type 2.");
                        break;
                    //3 = mission in Ashdale
                    case 3:
                        WriteLine("Call type 3.");
                        break;
                    //4 = mission in Downtown
                    case 4:
                        WriteLine("Call type 4.");
                        break;
                    //5 = mission in Palm Beach
                    case 5:
                        WriteLine("Call type 5.");
                        break;
                    //6 = mission in Scarlet Point
                    case 6:
                        WriteLine("Call type 6.");
                        break;
                    default:
                        //for debugging only
                        WriteLine("INVALID uint call given. (range 1 - 6)");
                        break;
                }
            }
            else
            {
                WriteLine("Call Rejected.");
            }
        }

        //Check IsWasted after EVERY mission.
        public static bool IsWasted(Player PLAYER)
        {
            if (PLAYER.PLAYER_HEALTH == 0 & PLAYER.ARMOUR_HEALTH == 0)
            {
                WriteLine($"GAME OVER. WASTED");
                return true;
                //END GAME
                Environment.Exit(0);
            }
            else
            {
                //for debugging only
                //WriteLine("NOT WASTED.");
                return false;
            }
        }

        //IN CAB LOGIC 
        public static void InCab(uint cost, string destination, Player PLAYER)
        {
            bool cabValidation = false;
            while (!cabValidation)
            {
                WriteLine("The cab is here, press 'Y' to jump in.");
                Display.TextColour("yellow >>", ">> ");
                string rawResponse = ReadLine();
                string response = rawResponse.ToUpper();
                if (response == "Y")
                {
                    Display.TextColour("cab", "Driving to your destination ...");
                    Thread.Sleep(1000);
                    WriteLine("    ____");
                    WriteLine(@" __/  |_\_");
                    WriteLine("|  _     _``-.");
                    WriteLine("'-(_)---(_)--'\n");

                    //Modify PLAYER stats and display
                    PLAYER.CURRENT_LOCATION = destination;
                    //var for ASCII map to use
                    string ASCIILocation = PLAYER.CURRENT_LOCATION;
                    PLAYER.CREDITS -= cost;
                    Thread.Sleep(3000);
                    Display.TextColour("cab", $"You have arrived at {PLAYER.CURRENT_LOCATION}.");
                    Thread.Sleep(2000);
                    Display.TextColour("cab", $"CREDITS: {PLAYER.CREDITS} \n");
                    //SHOW ASCII MAP
                    Display.Map(ASCIILocation);
                    //end while loop when correct response "Y/y" given.
                    cabValidation = true;
                    break;
                }
                else
                {
                    WriteLine("You have pressed an invalid key, please try again.");
                    Display.TextColour("yellow >>", ">> ");
                }
            }
        }

        //PLAYER NAME LOGIC
        public static void PlayerName(Player PLAYER)
        {
            WriteLine("Enter your name to play:");
            Display.TextColour("yellow >>", ">> ");
            string PLAYERName = ReadLine();

            //take player response again until value IS NOT null
            while (PLAYERName == "")
            {
                WriteLine("No input given, please enter your name to play.");
                Display.TextColour("yellow >>", ">> ");
                PLAYERName = ReadLine();
            }

            //assign value to PLAYER attribute
            PLAYER.PLAYER_NAME = PLAYERName;
            Thread.Sleep(1000);
            WriteLine($"Hello, {PLAYER.PLAYER_NAME}. Welcome. \n");
            Thread.Sleep(2000);
        }
    }
}