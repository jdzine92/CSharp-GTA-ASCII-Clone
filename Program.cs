//////////////////////////
// TEXT BASED GTA CLONE //
// BY JORDAN MILLS 2022 //
//////////////////////////

using System;
using static System.Console;
using System.Threading;


namespace JordansGTAClone
{
    class Game
    {
        public static void Main(string[] args)
        {
            //INIT PLAYER (name, credits, playerhealth, armourhealth, wantedlevel, currentlocation)
            //name is assigned to player object when player enters their name on startup.
            Player PLAYER = new Player("", 100, 10, 0, 0, "GLENDALE PRISON");


            //INIT WEAPONS (name, damage, cost, weaponowns, weaponavail, weaponselected)
            //FISTS, BRASS_KNUCKLES and BASEBALL_BAT are the inital weapons available.
            //FISTS is the default selected weapon
            Weapon FISTS = new Weapon("FISTS", 1, 0, true, false, true);
            Weapon BRASS_KNUCKLES = new Weapon("BRASS KNUCKLES", 2, 20, false, true, false);
            Weapon BASEBALL_BAT = new Weapon("BASEBALL BAT", 3, 25, false, true, false);
            Weapon HAMMER = new Weapon("HAMMER", 3, 25, false, false, false);
            Weapon MACHETE = new Weapon("MACHETE", 4, 40, false, false, false);
            Weapon GLOCK_PISTOL = new Weapon("GLOCK PISTOL", 5, 100, false, false, false);
            Weapon SHOTGUN = new Weapon("SHOTGUN", 6, 140, false, false, false);
            Weapon PETROL_BOMB = new Weapon("PETROL BOMB", 7, 190, false, false, false);
            Weapon MAC_10 = new Weapon("MAC 10", 8, 255, false, false, false);
            Weapon ROCKET_LAUNCHER = new Weapon("ROCKET LAUNCHER", 9, 450, false, false, false);
            Weapon BODY_ARMOUR = new Weapon("BODY ARMOUR", 0, 200, false, false, false);
            //WEAPONS array (to loop through weapons)
            Weapon[] WEAPONS = { FISTS, BRASS_KNUCKLES, BASEBALL_BAT, HAMMER, MACHETE, GLOCK_PISTOL, SHOTGUN, PETROL_BOMB, MAC_10, ROCKET_LAUNCHER, BODY_ARMOUR };

            /*
            do
            {
                Logic.IsWasted(PLAYER);
            }
            while (!Logic.IsWasted(PLAYER));
            */

            /*
            //UNIT TESTS

            //Weapon.ShowAll(WEAPONS);
            //Weapon.ShowOwnedWeapons(WEAPONS);
            //Weapon.ShowPurchaseableWeapons(WEAPONS);
            //Weapon.GetSelectedWeapon(WEAPONS);

            //Memory.Menu(PLAYER, WEAPONS);
            //Memory.Save(PLAYER, WEAPONS);

            //PLAYER.IsWasted();
            //PLAYER.PlayCards();
            */

            /*
            WriteLine("Incoming call from Tony. Press 'Y' to accept or 'N' to decline.");
            string callResponse = ReadLine();
            Logic.IncomingCall(callResponse, 1);
            Logic.IncomingCall(callResponse, 2);
            Logic.IncomingCall(callResponse, 3);
            Logic.IncomingCall(callResponse, 4);
            UnitTests.MainMenu(PLAYER);
            PlayCards.Start(PLAYER);
            Logic.IsWasted(PLAYER);
            Logic.InCab(20, "DOWNTOWN", PLAYER);
            
            //Weapon.UnlockWeapons(WEAPONS, "1");
            //Weapon.ShowPurchaseableWeapons(WEAPONS, PLAYER);
            //Reward.MysteryBox(PLAYER);
            //Memory.Save(PLAYER, WEAPONS);
            //Memory.Encrypt();
            //Memory.Decrypt();
            */

            //WELCOME SCREEN
            //Reward.BodyArmour(PLAYER);
            //Logic.IncomingCall(PLAYER, 1);
            //UnitTests.MainMenu(PLAYER);
            //PLAYER.IncreaseHealth();

            //PlayCards.Start(PLAYER);

            //SELECTED WEAPON LOGIC HERE (show owned weap and purchasable weaps)
            //Weapon.ShowOwnedWeapons(WEAPONS);
            //Weapon.ShowPurchaseableWeapons(WEAPONS, PLAYER);
            //Weapon.ShowOwnedWeapons(WEAPONS);
            //Weapon.ShowAll(WEAPONS);
            //Weapon.SelectWeapon(WEAPONS);
            //Weapon.ShowAll(WEAPONS);
            //PLAYER.PLAYER_HEALTH = 1;
            //PLAYER.IncreaseHealth(PLAYER);
            //PLAYER.ARMOUR_HEALTH = 10;
            //PLAYER.DecreaseHealthArmour(12);



            Display.Title();
            Thread.Sleep(1000);
            Display.TextColour("tony", "/// Welcome to Jordan's GTA clone\n");
            Thread.Sleep(1500);

            //LOAD/NEW GAME BEFORE STARTING
            Memory.StartMenu(PLAYER, WEAPONS);

            //BACKGROUND STORY INTRO
            Mission.Dialog(PLAYER, "intro");

            //INITAL STATS DISPLAY
            PLAYER.Stats();
            Display.Map("GLENDALE PRISON");

            //MISSION 1 DIALOG
            Mission.Dialog(PLAYER, "1");

            //SELECTED WEAPON LOGIC HERE (show owned weap and purchasable weaps)
            WriteLine("Select your weapon: ");
            Weapon.ShowOwnedWeapons(WEAPONS);
            Weapon.ShowPurchaseableWeapons(WEAPONS, PLAYER);
            Weapon.ShowOwnedWeapons(WEAPONS);
            Weapon.ShowAll(WEAPONS);
            Weapon.SelectWeapon(WEAPONS);



            Display.TextColour("narratorWriteLine", $"Narrator: Time to do business! Run in there with your {Weapon.ShowSelectedWeapon(WEAPONS)} and show them who's boss!");
            Display.Loading(400);
            Display.TextColour("tony", $"Tony: Good job, {PLAYER.PLAYER_NAME}. You took a little damage in there but you secured what we need.");
            Thread.Sleep(4000);
            Display.TextColour("tony", $"Tony: Swinging your {Weapon.ShowSelectedWeapon(WEAPONS)} like that brought us some heat! You'll notice your wanted level has increased. This means you could be arrested or injured by police at any time, stay safe!\n");
            Thread.Sleep(6000);

            //MISSION 1 COMPLETE
            Mission.CompleteMission(WEAPONS, PLAYER, "1");

            //PLAY CARDS WITH TONY (OPTIONAL)
            Logic.IncomingCall(PLAYER, 1);




        }
    }
}







