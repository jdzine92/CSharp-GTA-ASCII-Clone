# C# GTA ASCII Clone
### A GTA clone text based game made with C#, ASCII graphics complete with fleshed out logic, display and load/save states 
***

#### Program.cs - Main entry point for program. PLAYER instance and Weapon instances declared here, text rendered in main.
No functions to list in Program.cs <br>
All text display including game dialog can be found in Main.
***

#### Limits.cs - Contains game limits. These values are NOT to be modified.
###### Limit values are called as Limits.VAR_NAME
***

#### Player.cs - Contains user stats for PLAYER instance. Contains logic for modifying PLAYER values:
###### Player functions are called in Program.cs as PLAYER.FuncName(args). PLAYER is an instance of type Player, declared in Program.cs. It stores vital stats on the player.
+ Stats() - Displays PLAYER stats. Takes 0 args. <br>
+ WantedLevelUp() - Increases WANTED_LEVEL by 1 point. Takes 0 args. <br>
+ WantedLevelDown() - Decreases WANTED_LEVEL by 1 point. Takes 0 args. <br>
+ IncreaseCredits() - Increases CREDITS. Takes 1 arg (uint amount). <br>
+ DecreaseCredits() - Decreases CREDITS. Takes 1 arg (uint amount). <br>
+ IncreaseHealth() - Increases PLAYER_HEALTH. Takes 1 arg (uint amount). <br>
+ IncreaseArmour() - Increases ARMOUR_HEALTH. Takes 1 arg (uint amount). <br>
+ DecreaseHealthArmour() - Decreases ARMOUR_HEALTH AND PLAYER_HEALTH. Armour health taken before player health. Takes 1 arg (uint amount). <br>
Displays gameplay (all functions and files are called from here)
***

#### Display.cs - Contains functions to display various data to player:
@@ -36,6 +20,11 @@ All text display including game dialog can be found in Main.
+ TextColour() - Changes text display colours based on dialog, graphics etc. Takes 2 args (string colour, string text) <br>
***

#### Limits.cs - Contains game limits. These values are NOT to be modified.
###### Limit values are called as Limits.VAR_NAME
No functions to list in Limits.cs <br>
***

#### Logic.cs - Contains game logic for player inputs:
###### Logic functions are called in Program.cs as Logic.FuncName(args).
+ IncomingCall() - Handles user response when answering/declining calls. Takes 2 args (PLAYER, uint callType)
@@ -45,45 +34,50 @@ All text display including game dialog can be found in Main.
4 - Mission in Downtown <br>
5 - Mission in Palm Beach <br>
6 - Mission in Scarlet Point <br>
+ InCab() - Handles user response when game calls a cab. Takes 3 args (int cost, string destination, PLAYER). Response is handled in function. <br>
+ IsWasted() - Determines if PLAYER is wasted or not. Takes 1 arg (PLAYER). Checks 2 props in function, (PLAYER_HEALTH, ARMOUR_HEALTH). GAME OVER IF WASTED. <br>
+ InCab() - Handles user response when game calls a cab. Takes 3 args (int cost, string destination, PLAYER). Response is handled in function. <br>
+ PlayerName() - Checks that PLAYER_NAME is not empty when asked for user input. Takes 1 arg (PLAYER) <br>
***

#### Weapons.cs - Contains structure for weapons. Purchasing / selecting / owning.
###### Weapon functions are called in Program.cs as Weapon.FuncName(WEAPONS). WEAPONS is an array of type Weapon, declared in Program.cs. It lists all weapons in game.
+ ShowAll() DEBUGGING ONLY - Displays full weapons list including all properties. Takes 1 arg (WEAPONS[]). <br>
+ ShowOwnedWeapons() - Displays player owned weapons. Takes 1 arg (WEAPONS[]). <br>
+ ShowPurchaseableWeapons() - Displays available weapons for purchase. Takes 2 args (WEAPONS[], PLAYER). <br>
+ SelectWeapon() -  Displays the current selected weapon, allows PLAYER to change weapons. Takes 1 arg (WEAPONS[]). <br>
+ UnlockWeapons() - Allows new weapons to be unlocked based on game progress, takes 2 args (WEAPONS[], progress (range 1-5)) <br>
***

#### Mission.cs - Contains mission completion data.
###### Mission functions are called in Program.cs as Mission.CompleteMission(WEAPONS, PLAYER, "1"). WEAPONS is an array of type Weapon, declared in Program.cs. It lists all weapons in game. PLAYER is an object of type Player, containing all player stats. 
+ CompleteMission - Called on mission completion, mission is a uint corresponding to each mission number. takes 3 args (WEAPONS[], PLAYER, uint mission) <br>
***

#### Memory.cs - Allows load / save of gamestate.
###### Values saved to file are as follows: <br>
###### (PLAYER) PLAYER_NAME, PLAYER_HEALTH, ARMOUR_HEALTH, WANTED_LEVEL, CURRENT_LOCATION <br>
###### (WEAPONS) WEAP_NAME, WEAP_OWNS, WEAP_AVAIL, WEAP_SELECTED <br>
+ Menu() - Asks player if they want to save current game state. Takes 2 args (PLAYER and WEAPONS[]). These are passed when Save() is called from within Menu() <br>
+ Load() - Loads game data. Takes 0 args. Decrypt() called on file being loaded. <br>
+ Menu() - Asks player if they want to load/save/new current game state. Takes 2 args (PLAYER and WEAPONS[]). These are passed when Save() or Load() is called from within Menu() <br>
+ StartMenu() - Asks player if they want to load / start a new game. ONLY TO BE USED ON STARTUP. Takes 2 args (PLAYER and WEAPONS[]). These are passed when Save() or Load() is called from within StartMenu() <br>
+ Load() - Loads game data. Takes 2 args (PLAYER and WEAPONS[]). Decrypt() called on file being loaded. <br>
+ Save() - Saves game data. Takes 2 args (PLAYER and WEAPONS[]). Encrypt() called on save file. <br>
+ Encrypt() - Encrypts the game save file so player cannot as easily modify the file. <br>
+ Decrypt() - Decrypts the game save file for loading in game. <br>
+ Encrypt() - Encrypts the game save file so player cannot as easily modify the file. Takes 0 args, called by Save() <br>
+ Decrypt() - Decrypts the game save file for loading in game. Takes 0 args, called by Load() <br>
***

#### Mission.cs - Contains mission completion data.
###### Mission functions are called in Program.cs as Mission.CompleteMission(WEAPONS, PLAYER, "1"). WEAPONS is an array of type Weapon, declared in Program.cs. It lists all weapons in game. PLAYER is an object of type Player, containing all player stats. 
+ Dialog() - Contains in game dialog for each mission, take 2 args (PLAYER, string mission) <br>
+ CompleteMission() - Called on mission completion, mission is a string corresponding to each mission number. takes 3 args (WEAPONS[], PLAYER, string mission) <br>
***

#### PlayCards.cs - Mini game to play cards with Tony.
###### Cards game is called in Program.cs as PlayCards.Start(PLAYER). 
+ Start() - Starts the cards game, allows player to win credits. Max 4 rounds of play allowed per session. Takes 1 arg (PLAYER) <br>
***

#### Player.cs - Contains user stats for PLAYER instance. Contains logic for modifying PLAYER values:
###### Player functions are called in Program.cs as PLAYER.FuncName(args). PLAYER is an instance of type Player, declared in Program.cs. It stores vital stats on the player.
+ Stats() - Displays PLAYER stats. Takes 0 args. <br>
+ WantedLevelUp() - Increases WANTED_LEVEL. Takes 1 arg (int amount). <br>
+ WantedLevelDown() - Decreases WANTED_LEVEL. Takes 1 arg (int amount). <br>
+ IncreaseCredits() - Increases CREDITS. Takes 1 arg (uint amount). <br>
+ DecreaseCredits() - Decreases CREDITS. Takes 1 arg (uint amount). <br>
+ IncreaseHealth() - Increases PLAYER_HEALTH back to 10. (only when PLAYER_HEALTH < 3 player goes to hospital) Takes 1 arg (PLAYER). <br>
+ IncreaseArmour() - Increases ARMOUR_HEALTH. Takes 1 arg (uint amount). <br>
+ DecreaseHealthArmour() - Decreases ARMOUR_HEALTH AND/OR PLAYER_HEALTH. Armour health taken before player health. Takes 1 arg (int amount). <br>
***

#### Reward.cs - Gives player mystery box reward with credits inside.
###### Mystery box is called in Program.cs as Reward.MysteryBox(PLAYER);
+ MysteryBox() - Gives player credits (1-20) at random. Takes 1 arg (PLAYER). <br>
+ BodyArmour() - Gives player new body armour. Takes 1 arg (PLAYER) <br>
+ BodyArmour() - Gives player new body armour (10) . Takes 1 arg (PLAYER) <br>
***

#### UnitTests.cs - Tests every function from each file is working as intended. 
@@ -92,6 +86,16 @@ All text display including game dialog can be found in Main.
+ RunAnotherTest() - Allows option to run another test before exiting. Takes 1 arg (PLAYER), passed from MainMenu() <br>
***

#### Weapons.cs - Contains structure for weapons. Purchasing / selecting / owning.
###### Weapon functions are called in Program.cs as Weapon.FuncName(WEAPONS). WEAPONS is an array of type Weapon, declared in Program.cs. It lists all weapons in game.
+ ShowAll() DEBUGGING ONLY - Displays full weapons list including all properties. Takes 1 arg (WEAPONS[]). <br>
+ ShowSelectedWeapon() - Shows current selected weapon. FOR MISSION DIALOGS ONLY. Takes 1 arg (WEAPONS[]) <br>
+ SelectWeapon() -  Displays the current selected weapon AND allows PLAYER to change weapons. Takes 1 arg (WEAPONS[]). <br>
+ ShowOwnedWeapons() - Displays player owned weapons. Takes 1 arg (WEAPONS[]). <br>
+ ShowPurchaseableWeapons() - Displays available weapons for purchase. Takes 2 args (WEAPONS[], PLAYER). <br>
+ UnlockWeapons() - Allows new weapons to be unlocked based on game progress, takes 2 args (WEAPONS[], progress (range 1-5)) <br>
***

[logo]: https://github.com/jdzine92/CSharp-GTA-ASCII-Clone/blob/main/gtacsharp.PNG "GTA C# ASCII Game"
[gameplay]: https://github.com/jdzine92/CSharp-GTA-ASCII-Clone/blob/main/gameplay.png "Gameplay"
