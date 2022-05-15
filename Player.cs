using System;
using static System.Console;

//public associated with the INSTANCE. 
//static associated with the CLASS only.

namespace JordansGTAClone
{
    public class Player
    {
        //create public props(values)
        public string PLAYER_NAME
        { get; set; }

        public uint CREDITS
        { get; set; }

        public int PLAYER_HEALTH
        { get; set; }

        public int ARMOUR_HEALTH
        { get; set; }

        public int WANTED_LEVEL
        { get; set; }

        public string CURRENT_LOCATION
        { get; set; }

        //create class constructor and params
        public Player(string playername, uint credits, int playerhealth, int armourhealth, int wantedlevel, string currentlocation)
        {
            this.PLAYER_NAME = playername;
            this.CREDITS = credits;
            this.PLAYER_HEALTH = playerhealth;
            this.ARMOUR_HEALTH = armourhealth;
            this.WANTED_LEVEL = wantedlevel;
            this.CURRENT_LOCATION = currentlocation;
        }

        //display player stats
        public void Stats()
        {
            char armourASCII = Convert.ToChar(164);
            char wantedASCII = Convert.ToChar(187);

            Write("Loading Stats:  ");
            Display.Loading(120);

            Display.TextColour("stats", $"CREDITS £ : {CREDITS}");
            Thread.Sleep(1000);
            Display.TextColour("stats", $"HEALTH + : {PLAYER_HEALTH}");
            Thread.Sleep(1000);
            Display.TextColour("stats", $"ARMOUR {armourASCII} : {ARMOUR_HEALTH}");
            Thread.Sleep(1000);
            Display.TextColour("stats", $"WANTED LEVEL {wantedASCII} : {WANTED_LEVEL}");
            Thread.Sleep(1000);
            Display.TextColour("stats", $"CURRENT LOCATION ▲ : {CURRENT_LOCATION} \n");
            Thread.Sleep(1000);
        }

        //WANTED_LEVEL - MIN 0, MAX 5
        //MUST BE INT NOT UINT - DO NOT CHANGE THIS
        public void WantedLevelUp(int amount)
        {
            if (Limits.MAX_WANTED_LEVEL + amount >= 5)
            {
                WANTED_LEVEL = Limits.MAX_WANTED_LEVEL;
                WriteLine("You are already at the maximum wanted level! ");
                WriteLine($"WANTED LEVEL: {WANTED_LEVEL}");
            }
            else
            {
                WANTED_LEVEL += amount;
                WriteLine($"You have been upgraded to a {WANTED_LEVEL} star wanted level.");
                WriteLine($"WANTED LEVEL: {WANTED_LEVEL}");
            }
        }

        public void WantedLevelDown(int amount)
        {
            if (Limits.MIN_WANTED_LEVEL - amount <= 0)
            {
                WANTED_LEVEL = Limits.MIN_WANTED_LEVEL;
                WriteLine("You are no longer wanted! ");
                WriteLine($"WANTED LEVEL: {WANTED_LEVEL}");
            }
            else
            {
                WANTED_LEVEL -= amount;
                WriteLine($"You have been downgraded to a {WANTED_LEVEL} star wanted level.");
                WriteLine($"WANTED LEVEL: {WANTED_LEVEL}");
            }
        }

        //CREDITS - MIN 0, MAX 9999
        public void IncreaseCredits(uint amount)
        {
            if (Limits.MAX_CREDITS + amount > 9999)
            {
                CREDITS = Limits.MAX_CREDITS;
                WriteLine("You have reached the maximum credit allowance.");
                WriteLine($"CREDITS: {CREDITS}");
            }
            else
            {
                CREDITS += amount;
                WriteLine($"CREDITS: {CREDITS}");
            }
        }

        //bug error possible cause uint and int 
        public void DecreaseCredits(uint amount)
        {
            if (Limits.MIN_CREDITS - amount <= 0)
            {
                CREDITS = Limits.MIN_CREDITS;
                WriteLine("You are out of credits.");
            }
            else
            {
                CREDITS -= amount;
                WriteLine($"CREDITS: {CREDITS}");
            }
        }

        //RESETS HEALTH TO 10 WHEN AT HOSPITAL, CAN ONLY GO TO HOSPITAL IF HEALTH <= 3
        public void IncreaseHealth(Player PLAYER)
        {
            if (PLAYER_HEALTH <= Limits.MIN_HOSPITAL_HEALTH)
            {
                //take 25 credits from player for hospital admission
                uint hospitalCost = 25;
                Display.TextColour("narratorWriteLine", "Narrator: Your health is low, you don't look so good. Take yourself to the hospital.");
                Thread.Sleep(3500);
                Display.TextColour("narratorWriteLine", "Narrator: A cab is on its way, don't worry its free.");
                Thread.Sleep(3500);
                Logic.InCab(0, "HOSPITAL", PLAYER);
                if (CREDITS > hospitalCost)
                {
                    CREDITS -= hospitalCost;
                    PLAYER_HEALTH = Limits.MAX_PLAYER_HEALTH;
                    WriteLine("Discharged...");
                    Thread.Sleep(1500);
                    WriteLine($"HEALTH: + {PLAYER_HEALTH}");
                    Thread.Sleep(1500);

                }
                else
                {
                    WriteLine("You do not have enough credits to pay for your hospital treatment.");
                    Thread.Sleep(1500);
                    WriteLine($"HEALTH: + {PLAYER_HEALTH}");
                    Thread.Sleep(1500);
                }
            }

            //continue with game if health > 3
        }

        /* The players health and armour work together so that damage is taken by the armour first,
        when there is no armour left damage will be taken by health. If both 0 WASTED */
        public void DecreaseHealthArmour(int amount)
        {
            //Armour / health logic
            if (ARMOUR_HEALTH >= amount)
            {
                ARMOUR_HEALTH -= amount;
                WriteLine($"Your armour took a hit!");
                WriteLine($"ARMOUR: {ARMOUR_HEALTH}");
            }
            else
            {
                ARMOUR_HEALTH -= amount;
                //store remaining damage (which will be subtracted from health)
                int remaining = ARMOUR_HEALTH;
                //set armour to 0 after storing remaining, as can not be a negative value
                ARMOUR_HEALTH = Limits.MIN_ARMOUR_HEALTH;
                WriteLine($"Your armour took a hit!");
                WriteLine($"ARMOUR: {ARMOUR_HEALTH}");

                //Player health logic
                if (remaining < PLAYER_HEALTH)
                {
                    //+= because of negative value
                    PLAYER_HEALTH += remaining;
                    WriteLine($"Your health took a hit!");
                    WriteLine($"HEALTH: {PLAYER_HEALTH}");
                }
                else
                {
                    //set player health to 0 and END GAME
                    PLAYER_HEALTH = Limits.MIN_PLAYER_HEALTH;
                    WriteLine("WASTED");
                }
            }
        }
    }
}
