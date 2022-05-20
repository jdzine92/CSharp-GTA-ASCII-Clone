# C# GTA ASCII Clone
### About: A GTA clone text based game made with C#, ASCII display, complete with weapons, logic, load/save states, unit testing and more.
#### Development on this project commenced in late 2021.
![alt text][gameplay1]
<br>
![alt text][gameplay2]
<br>
![alt text][gameplay3]
### How to play:
+ **pull this repo**
+ **Run GTA-CLONE.exe - located in /bin/Debug/net6.0/**
***
#### Files / Functions listed below:
#### Program.cs - Main entry point for program. PLAYER instance and Weapon instances declared here, text rendered in main.
No functions to list in Program.cs <br>
All functions are called from here.
***

#### Limits.cs - Contains game limits. These values are NOT to be modified.
###### Limit values are called as Limits.VAR_NAME
:triangular_flag_on_post: MAX_WANTED_LEVEL <br>
:triangular_flag_on_post: MAX_CREDITS <br>
:triangular_flag_on_post: MAX_PLAYER_HEALTH <br>
:triangular_flag_on_post: MAX_ARMOUR_HEALTH <br>
:triangular_flag_on_post: MAX_PLAY_CARDS_ROUNDS <br>
:triangular_flag_on_post: MIN_WANTED_LEVEL <br>
:triangular_flag_on_post: MIN_CREDITS <br>
:triangular_flag_on_post: MIN_PLAYER_HEALTH <br>
:triangular_flag_on_post: MIN_ARMOUR_HEALTH <br>
:triangular_flag_on_post: MIN_HOSPITAL_HEALTH <br>
***

#### Player.cs - Contains user stats for PLAYER instance. Contains logic for modifying PLAYER values:
###### Player functions are called in Program.cs as PLAYER.FuncName(args). PLAYER is an instance of type Player, declared in Program.cs. It stores vital stats on the player.
:small_blue_diamond: Stats() - Displays PLAYER stats. Takes 0 args. <br>
:small_blue_diamond: WantedLevelUp() - Increases WANTED_LEVEL. Takes 1 arg (int amount) <br>
:small_blue_diamond: WantedLevelDown() - Decreases WANTED_LEVEL. Takes 1 arg (int amount) <br>
:small_blue_diamond: IncreaseCredits() - Increases CREDITS. Takes 1 arg (uint amount). <br>
:small_blue_diamond: DecreaseCredits() - Decreases CREDITS. Takes 1 arg (uint amount). <br>
:small_blue_diamond: IncreaseHealth() - Increases PLAYER_HEALTH. Takes 1 arg (uint amount). ONLY WHEN HEALTH <=3 (GO TO HOSPITAL) <br>
:small_blue_diamond: DecreaseHealthArmour() - Decreases ARMOUR_HEALTH AND PLAYER_HEALTH. Armour health taken before player health. Takes 1 arg (uint amount). <br>
***

#### Display.cs - Contains functions to display various data to player:
:small_blue_diamond: Title() - Displays ASCII game title. Takes 0 args. <br>
:small_blue_diamond: Map() - Displays ASCII maps. Takes 1 arg (string currentLocation) <br>
:small_blue_diamond: DisplayCard() - Displays ASCII cards for mini cards game. Takes 1 arg (int num) <br>
:small_blue_diamond: Loading() - Displays loading bar. Takes 1 arg (int ms) time in ms x20 <br>
:small_blue_diamond: TextColour() - Changes text display colours based on dialog, graphics etc. Takes 2 args (string colour, string text) <br>
***

#### Logic.cs - Contains game logic for player inputs:
###### Logic functions are called in Program.cs as Logic.FuncName(args).
:small_blue_diamond: IncomingCall() - Handles user response when answering/declining calls. Takes 2 args (PLAYER, uint callType) <br>
:small_blue_diamond: InCab() - Handles user response when game calls a cab. Takes 3 args (int cost, string destination, PLAYER). Response is handled in function. <br>
:small_blue_diamond: IsWasted() - Determines if PLAYER is wasted or not. Takes 1 arg (PLAYER). Checks 2 props in function, (PLAYER_HEALTH, ARMOUR_HEALTH). **GAME OVER IF WASTED, CHECK AFTER EACH MISSION** <br>
:small_blue_diamond: PlayerName() - Checks that PLAYER_NAME is not empty when asked for user input. Takes 1 arg (PLAYER) <br>
***

#### Weapons.cs - Contains structure for weapons. Purchasing / selecting / owning.
###### Weapon functions are called in Program.cs as Weapon.FuncName(WEAPONS). WEAPONS is an array of type Weapon, declared in Program.cs. It lists all weapons in game.
:small_blue_diamond: ShowAll() DEBUGGING ONLY - Displays full weapons list including all properties. Takes 1 arg (WEAPONS[]). <br>
:small_blue_diamond: ShowSelectedWeapon() - Displays current selected weapon. For dialog use only. Takes 1 arg (WEAPONS[]). <br>
:small_blue_diamond: SelectWeapon() -  Displays the current selected weapon, allows PLAYER to change weapons. Takes 1 arg (WEAPONS[]). <br>
:small_blue_diamond: ShowOwnedWeapons() - Displays player owned weapons. Takes 1 arg (WEAPONS[]). <br>
:small_blue_diamond: ShowPurchaseableWeapons() - Displays available weapons for purchase. Takes 2 args (WEAPONS[], PLAYER). <br>
:small_blue_diamond: UnlockWeapons() - Allows new weapons to be unlocked based on game progress, takes 2 args (WEAPONS[], progress (range 1-5)) <br>
***

#### Mission.cs - Contains mission completion data.
###### Mission functions are called in Program.cs as Mission.CompleteMission(WEAPONS, PLAYER, "1"). WEAPONS is an array of type Weapon, declared in Program.cs. It lists all weapons in game. PLAYER is an object of type Player, containing all player stats. 
:small_blue_diamond: Dialog() - Displays all mission related dialog. Takes 2 args (PLAYER, string mission) <br>
:small_blue_diamond: CompleteMission() - Called on mission completion, mission is a uint corresponding to each mission number. takes 3 args (WEAPONS[], PLAYER, uint mission) <br>
***

#### Memory.cs - Allows load / save of gamestate.
###### Values saved to file are as follows: <br>
###### (PLAYER) PLAYER_NAME, PLAYER_HEALTH, ARMOUR_HEALTH, WANTED_LEVEL, CURRENT_LOCATION <br>
###### (WEAPONS) WEAP_NAME, WEAP_OWNS, WEAP_AVAIL, WEAP_SELECTED <br>
:small_blue_diamond: Menu() - Asks player if they want to save current game state. Takes 2 args (PLAYER and WEAPONS[]). These are passed when Save() is called from within Menu() <br>
:small_blue_diamond: StartMenu() - Asks player if they want to load / start a new game. ONLY TO BE USED ON STARTUP. Takes 2 args (PLAYER and WEAPONS[]). These are passed when Save() or Load() is called from within StartMenu() <br>
:small_blue_diamond: Load() - Loads game data. Takes 2 args (PLAYER and WEAPONS[]). Decrypt() called on file being loaded. <br>
:small_blue_diamond: Save() - Saves game data. Takes 2 args (PLAYER and WEAPONS[]). Encrypt() called on save file. <br>
:small_blue_diamond: Encrypt() - Encrypts the game save file so player cannot as easily modify the file. Takes 0 args, called by Save() <br>
:small_blue_diamond: Decrypt() - Decrypts the game save file for loading in game. Takes 0 args, called by Load() <br>
***

#### PlayCards.cs - Mini game to play cards with Tony.
###### Cards game is called in Program.cs as PlayCards.Start(PLAYER). 
:small_blue_diamond: Start() - Starts the cards game, allows player to win credits. Max 4 rounds of play allowed per session. Takes 1 arg (PLAYER) <br>
***

#### Reward.cs - Gives player mystery box reward with credits inside.
###### Mystery box is called in Program.cs as Reward.MysteryBox(PLAYER);
:small_blue_diamond: MysteryBox() - Gives player credits (1-20) at random. Takes 1 arg (PLAYER). <br>
:small_blue_diamond: BodyArmour() - Gives player new body armour (10) . Takes 1 arg (PLAYER) <br>
***

#### UnitTests.cs - Tests every function from each file is working as intended. 
:small_blue_diamond: MainMenu() - Shows the main unit tests menu. **ONLY FOR TESTING AND DEBUGGING**
:small_blue_diamond: RunAnotherTest() - Allows option to run another test before exiting. Takes 1 arg (PLAYER), passed from MainMenu() <br>
***

[gameplay1]: https://github.com/jdzine92/CSharp-GTA-ASCII-Clone/blob/main/gtacsharp.PNG "GTA C# ASCII Game"
[gameplay2]: https://github.com/jdzine92/CSharp-GTA-ASCII-Clone/blob/main/gameplay.png "Gameplay"
[gameplay3]: https://github.com/jdzine92/CSharp-GTA-ASCII-Clone/blob/main/cards-gameplay.png "Gameplay cards"
