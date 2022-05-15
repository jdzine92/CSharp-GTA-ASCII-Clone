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

            bool boxValidation = false;
            while (!boxValidation)
            {
                WriteLine(" ________ ");
                WriteLine("|  ----  |");
                WriteLine("|   ??   |");
                WriteLine("|  ----  |");
                WriteLine("|________|\n");
                WriteLine("You found a mystery box ! Press 'Y' to open it.");
                Display.TextColour("yellow >>", ">> ");
                string rawResponse = ReadLine();
                string response = rawResponse.ToUpper();
                if (response == "Y")
                {
                    Display.Loading(120);
                    WriteLine($"There are {randomCredits} credits inside.");
                    PLAYER.CREDITS += randomCredits;
                    Thread.Sleep(2000);
                    WriteLine($"You now have {PLAYER.CREDITS} credits.");
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

            WriteLine("You found body armour !");
            PLAYER.ARMOUR_HEALTH = Limits.MAX_ARMOUR_HEALTH;
            WriteLine($"ARMOUR: {armourASCII} {PLAYER.ARMOUR_HEALTH}");
        }
    }
}