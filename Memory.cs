using System;
using static System.Console;
using System.IO;
using System.Reflection;

namespace JordansGTAClone
{
    class Memory
    {
        //PLAYER and WEAPONS passed from this function into Save().
        public static void Menu(Player PLAYER, Weapon[] WEAPONS)
        {
            bool menuValidation = false;
            while (!menuValidation)
            {
                WriteLine(" ______");
                WriteLine("| |__| |");
                WriteLine("|  ()  |");
                WriteLine("|______|\n");
                WriteLine("Load / Save game ? Press '1' to LOAD, '2' to SAVE or '3' to start a NEW game:");
                Display.TextColour("yellow >>", ">> ");
                string rawResponse = ReadLine();
                string response = rawResponse.ToUpper();
                if (response == "1")
                {
                    //Load();
                    menuValidation = true;
                    break;
                }
                else if (response == "2")
                {
                    Save(PLAYER, WEAPONS);
                    menuValidation = true;
                    break;
                }
                else if (response == "3")
                {
                    //continue with a new game
                    break;
                }
                else
                {
                    WriteLine("You have pressed an invalid key, please try again.");
                }
            }
        }

        //Only display this menu at game startup, NO SAVE OPTION LISTED
        public static void StartMenu(Player PLAYER, Weapon[] WEAPONS)
        {
            bool menuValidation = false;
            while (!menuValidation)
            {
                WriteLine(" ______");
                WriteLine("| |__| |");
                WriteLine("|  ()  |");
                WriteLine("|______|\n");
                WriteLine("Load game ? Press '1' to LOAD, or '2' to start a NEW game:");
                Display.TextColour("yellow >>", ">> ");
                string rawResponse = ReadLine();
                string response = rawResponse.ToUpper();
                if (response == "1")
                {
                    Load(PLAYER, WEAPONS);
                    menuValidation = true;
                    break;
                }
                else if (response == "2")
                {
                    //continue with a new game
                    //PLAYER NAME ENTRY
                    Logic.PlayerName(PLAYER);
                    menuValidation = true;
                    break;
                }
                else
                {
                    WriteLine("You have pressed an invalid key, please try again.");
                }
            }
        }

        public static void Load(Player PLAYER, Weapon[] WEAPONS)
        {
            //read gamesave file
            WriteLine("\nReading game save data ...");
            Thread.Sleep(500);
            Display.Loading(50);
            string readGameSave = File.ReadAllText("SAVES/gamesave.txt");

            //specify where to split data with delimiters
            char[] delimiters = { ':', ',', '.' };

            //split data with above delimiters
            string[] gameSave = readGameSave.Split(delimiters);

            //declare a blank array to store data in

            // Loop through data 
            foreach (var data in gameSave)
            {
                WriteLine(data); //just to see output, all is correct here
            }

        }



        //IMPORTANT: KEY VALUE PAIRS ARE SEPARATED AS SO:
        // KEY : VALUE, VALUE, VALUE. (. INDICATES END OF LINE)
        public static void Save(Player PLAYER, Weapon[] WEAPONS)
        {
            //if save file does not exist, create new file.
            if (!File.Exists("gamesave.txt"))
            {
                File.Create("gamesave.txt");
            }

            //get PLAYER values for each prop
            Type t = PLAYER.GetType();
            PropertyInfo[] props = t.GetProperties();

            //assign blank string to write data to
            string saveData = "";

            //save game loading screen
            var date = DateTime.Now;
            WriteLine(date);
            WriteLine("Saving game data, please wait ...");
            Thread.Sleep(500);
            Display.Loading(120);
            Thread.Sleep(500);

            //loop through PLAYER values and write to saveData
            foreach (var value in props)
                if (value.GetIndexParameters().Length == 0)
                {
                    //WRITE ALL PLAYER VALUES ( name : value. )
                    string writePlayerValues = $"{value.Name}: {value.GetValue(PLAYER)}.\n";
                    saveData += writePlayerValues;
                }

            //loop through required WEAPON values and write to saveData
            foreach (Weapon w in WEAPONS)
            {
                //convert bool to string lower for encrypt/decrypt functions
                string booltostrWO = w.WEAP_OWNS.ToString().ToLower();
                string booltostrWA = w.WEAP_AVAIL.ToString().ToLower();
                string booltostrWS = w.WEAP_SELECTED.ToString().ToLower();

                //WRITE ALL WEAPON VALUES ( name : value, value, value.)
                string writeWeaponValues = $"{w.WEAP_NAME}: {booltostrWO}, {booltostrWA}, {booltostrWS}.\n";
                saveData += writeWeaponValues;
            }

            //Write plain text data to save file 
            File.WriteAllText("gamesave.txt", saveData);
            //ENCRYPT plain text data
            //Encrypt();
            //SUCCESS
            WriteLine("Save Complete.\n");
        }

        //SAVE FILE ENCRYPTION
        public static void Encrypt()
        {
            //define alphabet array to work with
            char[] alphabet = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '_', ',', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 't', 'f', 'r', 'a', 'u', 'l', 'e', 's', ' ' };

            //convert saveFile data (string) to char[] to ENCRYPT
            string saveFile = File.ReadAllText("gamesave.txt");
            char[] saveFileArr = saveFile.ToCharArray();

            //create empty encrypted array, same length as saveFileArr
            char[] encryptedFile = new char[saveFileArr.Length];

            //iterate through saveFileArr
            for (int i = 0; i < saveFileArr.Length; i++)
            {
                char letter = saveFileArr[i];
                int index = Array.IndexOf(alphabet, letter);
                //encrypt by shifting >> 7, handle out of range exception (wrap around)
                int indexShift = (index + 7) % alphabet.Length;
                char encryptedChar = alphabet[indexShift];
                //add each encryptedChar to encryptedFile array
                encryptedFile[i] = encryptedChar;
            }

            //CONVERT encryptedFile (char[]) to string and SAVE
            var encryptedFileSTR = new string(encryptedFile);
            File.WriteAllText("gamesave.txt", encryptedFileSTR);

            //DEBUGGING ONLY
            Console.WriteLine("Save file encrypted:");
            Console.WriteLine(encryptedFileSTR);
        }

        //SAVE FILE ENCRYPTION
        public static void Decrypt()
        {
            //define alphabet array to work with
            char[] alphabet = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '_', ',', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 't', 'f', 'r', 'a', 'u', 'l', 'e', 's', ' ' };

            //convert saveFile data (string) to char[] to DECRYPT
            string saveFile = File.ReadAllText("gamesave.txt");
            char[] saveFileArr = saveFile.ToCharArray();

            //create empty encrypted array, same length as inputMessage array
            char[] decryptedFile = new char[saveFile.Length];

            //iterate through inputMessage array
            for (int i = 0; i < saveFile.Length; i++)
            {
                char letter = saveFile[i];
                int index = Array.IndexOf(alphabet, letter);
                //decrypt by shifting >> 41, handle out of range exception (wrap around)
                int indexShift = (index + 41) % alphabet.Length;
                char decryptedChar = alphabet[indexShift];
                //add each encryptedChar to encryptedMessage array
                decryptedFile[i] = decryptedChar;
            }

            //DEBUGGING ONLY
            Console.WriteLine("Save file decrypted:");
            Console.WriteLine(decryptedFile);
        }
    }
}