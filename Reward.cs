using static System.Console;

namespace JordansGTAClone
{
    class Reward
    {
        //GIVES PLAYER MYSTERY BOX WITH 1-20 CREDITS INSIDE
        public static void MysteryBox(Player PLAYER)
        {
            Random rnd = new Random();
            uint randomCredits = (uint)rnd.Next(1, 21);

             Display.TextColour("reward", " ________ ");
            Display.TextColour("reward", "|  ----  |");
            Display.TextColour("reward", "|   ??   |");
            Display.TextColour("reward", "|  ----  |");
            Display.TextColour("reward", "|________|\n");
            Display.TextColour("narratorWriteLine","Narrator: You found a mystery box ! Press 'Y' to open it.");
            Display.TextColour("yellow >>", ">> ");

            bool boxValidation = false;
            while (!boxValidation)
            {
                string rawResponse = ReadLine();
                string response = rawResponse.ToUpper();
                if (response == "Y")
                {
                    Display.Loading(120);
                    WriteLine($"There are {randomCredits} credits inside.");
                    PLAYER.CREDITS += randomCredits;
                    Thread.Sleep(2000);
                    WriteLine($"You now have {PLAYER.CREDITS} credits.\n");
                    Thread.Sleep(2000);
                    boxValidation = true;
                    break;
                }
                else
                {
                    WriteLine("You have pressed an invalid key, please try again.");
                    Display.TextColour("yellow >>", ">> ");
                }
            }

        }
        //SETS BODY ARMOUR TO 10 (MAX) WHEN CALLED
        public static void BodyArmour(Player PLAYER)
        {
            char armourASCII = Convert.ToChar(164);
            Display.TextColour("reward", @"\-----/");
            Display.TextColour("reward", " |   |");
            Display.TextColour("reward", "o-----o");
            Display.TextColour("reward", "o-----o");
            Display.TextColour("reward", "[[] []]\n");
            Thread.Sleep(2000);
            Display.TextColour("narratorWriteLine", "Narrator:You found body armour !");
            Thread.Sleep(2000);
            PLAYER.ARMOUR_HEALTH = Limits.MAX_ARMOUR_HEALTH;
            Display.TextColour("stats", $"ARMOUR: {armourASCII} {PLAYER.ARMOUR_HEALTH}");
            Thread.Sleep(2000);
        }
    }
}