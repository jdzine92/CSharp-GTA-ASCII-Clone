using System;
using static System.Console;

namespace JordansGTAClone
{
    class Weapon
    {
        //DEFINE WEAPON ATTRIBUTES
        public string WEAP_NAME
        { get; set; }

        public uint WEAP_DAMAGE
        { get; set; }

        public uint WEAP_COST
        { get; set; }

        public bool WEAP_OWNS
        { get; set; }

        public bool WEAP_AVAIL
        { get; set; }

        public bool WEAP_SELECTED
        { get; set; }

        public Weapon(string name, uint damage, uint cost, bool weaponowns, bool weaponavail, bool weaponselected)
        {
            this.WEAP_NAME = name;
            this.WEAP_DAMAGE = damage;
            this.WEAP_COST = cost;
            this.WEAP_OWNS = weaponowns;
            this.WEAP_AVAIL = weaponavail;
            this.WEAP_SELECTED = weaponselected;
        }

        //DISPLAYS FULL WEAPON INVENTORY (FOR DEBUGGING ONLY)
        public static void ShowAll(Weapon[] WEAPONS)
        {
            WriteLine("Weapons Inventory: \n");
            foreach (Weapon w in WEAPONS)
            {
                WriteLine($" WEAPON: {w.WEAP_NAME} || DAMAGE: {w.WEAP_DAMAGE} || COST: {w.WEAP_COST} || OWNED: {w.WEAP_OWNS} || AVAILABLE: {w.WEAP_AVAIL} || SELECTED: {w.WEAP_SELECTED} \n");
            }
        }

        //DISPLAYS CURRENT SELECTED WEAPON
        public static string ShowSelectedWeapon(Weapon[] WEAPONS)
        {
            foreach (Weapon w in WEAPONS)
            {
                if (w.WEAP_SELECTED == true)
                {
                    return $"{w.WEAP_NAME}";
                }
                else
                {
                    return "true";
                }
            }
            return "false";
        }

        public static void SelectWeapon(Weapon[] WEAPONS)
        {
            WriteLine("Select a weapon to use: ");
            foreach (Weapon w in WEAPONS)
            {
                if (w.WEAP_SELECTED == true)
                {
                    WriteLine($"{w.WEAP_NAME} is your current selected weapon, would you like to change it ? Press 'Y' for yes or 'N' for no.");
                }
                string rawResponse = ReadLine();
                string response = rawResponse.ToUpper();
                if (response == "Y" && w.WEAP_OWNS == true && w.WEAP_SELECTED == false)
                {
                    WriteLine($"{w.WEAP_NAME}");
                    WriteLine($"Press 'Y' to select this weapon or 'N' to skip to the next weapon.");
                    string rawResponse2 = ReadLine();
                    string response2 = rawResponse2.ToUpper();
                    if (response2 == "Y")
                    {
                        //sets weapon to current selected
                        w.WEAP_SELECTED = true;
                        WriteLine($"{w.WEAP_NAME} selected.");
                        break;
                    }
                }
                else if (response == "N")
                {
                    WriteLine($"{w.WEAP_NAME} is still your selected weapon.");
                    break;
                }
            }
        }

        //DISPLAYS PLAYER OWNED WEAPONS
        public static void ShowOwnedWeapons(Weapon[] WEAPONS)
        {
            WriteLine("Weapons Owned: \n");
            //show each owned weapon from WEAPONS array (WEAP_OWNS)
            foreach (Weapon w in WEAPONS)
            {
                if (w.WEAP_OWNS == true)
                {
                    WriteLine($"{w.WEAP_NAME} \n");
                }
            }
        }

        //DISPLAYS PURCHASEABLE WEAPONS (UNLOCKABLE BY GAME PROGRESSION)
        public static void ShowPurchaseableWeapons(Weapon[] WEAPONS, Player PLAYER)
        {
            //MENU and ASCII 
            WriteLine(@" ,___________________________________");
            WriteLine(@"|______________,----------._ [____]  ""-,__  __....------------``");
            WriteLine(@"               (_(||||||||||||)___________/   ""            ////|");
            WriteLine(@"                  `----------' ///////[ ))' -,                 | ");
            WriteLine(@"                                       ""    `,  _,--....___    |");
            WriteLine(@"                                               `/           """"");
            WriteLine("Weapons Available for purchase: \n");
            foreach (Weapon w in WEAPONS)
            {
                if (w.WEAP_AVAIL == true && w.WEAP_OWNS == false)
                {
                    //Show each purchasable weapon from WEAPONS array (WEAP_AVAIL)
                    WriteLine($" WEAPON: {w.WEAP_NAME} || COST: {w.WEAP_COST} || DAMAGE: {w.WEAP_DAMAGE}");
                    WriteLine("Press 'Y' to purchase this weapon or 'N' to skip to the next weapon. \n");

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

                    //logic to handle response (Y or N)
                    if (response == "Y")
                    {
                        PLAYER.CREDITS -= w.WEAP_COST;
                        w.WEAP_OWNS = true;
                        w.WEAP_AVAIL = false;
                        WriteLine($"{w.WEAP_NAME} purchased.");
                        WriteLine($"CREDITS: {PLAYER.CREDITS}\n");
                        Thread.Sleep(1000);
                    }
                }
            }
            //show message to player at end of foreach loop on WEAPONS array
            WriteLine("There are no more weapons available for purchase.");
        }

        //UNLOCK WEAPONS BASED ON GAME PROGRESSION
        //FISTS, BRASS_KNUCKLES and BASEBALL_BAT are available from beginning.
        public static void UnlockWeapons(Weapon[] WEAPONS, string progress)
        {
            switch (progress)
            {
                //unlock (HAMMER, MACHETE) after 1ST mission QUAY SIDE complete.
                case "1":
                    WEAPONS[3].WEAP_AVAIL = true; //WEAPONS[3] = HAMMER
                    WEAPONS[4].WEAP_AVAIL = true; //WEAPONS[4] = MACHETE
                    break;

                //unlock (GLOCK_PISTOL, BODY_ARMOUR) after 2ND mission ASHDALE complete
                case "2":
                    WEAPONS[5].WEAP_AVAIL = true; //WEAPONS[5] = GLOCK_PISTOL
                    WEAPONS[10].WEAP_AVAIL = true; //WEAPONS[10] = BODY_ARMOUR
                    break;

                //unlock (SHOTGUN) after 3RD mission COTTLETON WOODS complete
                case "3":
                    WEAPONS[6].WEAP_AVAIL = true; //WEAPONS[6] = SHOTGUN
                    break;

                //unlock (PETROL_BOMB) after 4TH mission SCARLET POINT complete
                case "4":
                    WEAPONS[7].WEAP_AVAIL = true; //WEAPONS[7] = PETROL_BOMB
                    break;

                //unlock (MAC_10, ROCKET_LAUNCHER) after 5TH mission PALM BEACH complete
                case "5":
                    WEAPONS[8].WEAP_AVAIL = true; //WEAPONS[8] = MAC_10
                    WEAPONS[9].WEAP_AVAIL = true; //WEAPONS[9] = ROCKET_LAUNCHER
                    break;

                default:
                    //for debugging only
                    WriteLine("INVALID PROGRESS (RANGE 1-5)");
                    break;
            }
        }
    }
}





