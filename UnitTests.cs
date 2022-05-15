using System;
using static System.Console;

namespace JordansGTAClone
{
    class UnitTests
    {
        public static void MainMenu(Player PLAYER)
        {
            bool adminValidated = false;
            while (!adminValidated)
            {
                WriteLine("Unit test module active. NOT FOR GAMEPLAY.");
                Thread.Sleep(1000);
                string password = "12344";
                WriteLine("Enter Password:");
                Write(">> ");
                string response = ReadLine();
                if (response == "12344")
                {
                    WriteLine("Login success!");
                    adminValidated = true;
                    WriteLine("Press 1 for DISPLAY testing, 2 for PLAYER testing, 3 for WEAPONS testing, 4 for LOGIC testing, 5 for MEMORY testing:");
                    WriteLine("Press 0 to EXIT unit testing.");
                    Write(">> ");
                    string menuResponse = ReadLine();
                    //cycle through menu options
                    switch (menuResponse)
                    {
                        case "0":
                            Environment.Exit(0);
                            break;

                        case "1":
                            WriteLine("DISPLAY: Press 1 for TITLE test, 2 for MAP test, 3 for LOADING test:");
                            Write(">> ");
                            string displayResponse = ReadLine();
                            switch (displayResponse)
                            {
                                case "1":
                                    WriteLine("About: Test the ASCII title screen is displayed when called: ");
                                    Thread.Sleep(3000);
                                    Display.Title();
                                    Thread.Sleep(1000);
                                    WriteLine("TEST SUCCESS.");
                                    Thread.Sleep(1000);
                                    RunAnotherTest(PLAYER);
                                    break;

                                case "2":
                                    WriteLine("About: Test the ASCII map is displayed and the location triangle is correct: ");
                                    Thread.Sleep(3000);
                                    WriteLine("Press 1 for DOWNTOWN, 2 for QUAY SIDE, 3 for GLENDALE PRISON, 4 for SCARLET POINT, 5 for ASHDALE, 6 for COTTLETON WOODS, 7 for PALM BEACH:");
                                    Write(">> ");
                                    string mapResponse = ReadLine();
                                    switch (mapResponse)
                                    {
                                        case "1":
                                            Display.Map("DOWNTOWN");
                                            Thread.Sleep(1000);
                                            WriteLine("TEST SUCCESS.");
                                            break;

                                        case "2":
                                            Display.Map("QUAY SIDE");
                                            Thread.Sleep(1000);
                                            WriteLine("TEST SUCCESS.");
                                            break;

                                        case "3":
                                            Display.Map("GLENDALE PRISON");
                                            Thread.Sleep(1000);
                                            WriteLine("TEST SUCCESS.");
                                            break;

                                        case "4":
                                            Display.Map("SCARLET POINT");
                                            Thread.Sleep(1000);
                                            WriteLine("TEST SUCCESS.");
                                            break;

                                        case "5":
                                            Display.Map("ASHDALE");
                                            Thread.Sleep(1000);
                                            WriteLine("TEST SUCCESS.");
                                            break;

                                        case "6":
                                            Display.Map("COTTLETON WOODS");
                                            Thread.Sleep(1000);
                                            WriteLine("TEST SUCCESS.");
                                            break;

                                        case "7":
                                            Display.Map("PALM BEACH");
                                            Thread.Sleep(1000);
                                            WriteLine("TEST SUCCESS.");
                                            break;

                                        default:
                                            WriteLine("OUT OF RANGE");
                                            break;
                                    }
                                    break; //end of MAP menu

                                case "3":
                                    WriteLine("About: Test the loading bar is functioning. Enter loading time in milliseconds / 20. (1 second = 50):");
                                    Write(">> ");
                                    int loadingResponse = Convert.ToInt32(ReadLine());
                                    Display.Loading(loadingResponse);
                                    WriteLine($"The bar loaded for {loadingResponse * 20} milliseconds.");
                                    WriteLine("TEST SUCCESS.");
                                    break;

                                default:
                                    WriteLine("OUT OF RANGE");
                                    break;

                            }
                            break; //end of DISPLAY menu

                        case "2":
                            WriteLine("PLAYER: Press 1 for STATS, 2 for WANTEDLEVELUP, 3 for WANTEDLEVELDOWN");
                            Write(">> ");
                            string playerResponse = ReadLine();
                            switch (playerResponse)
                            {
                                case "1":
                                    WriteLine("About: Test player stats are displayed correctly:");
                                    Thread.Sleep(2000);
                                    PLAYER.Stats();
                                    WriteLine("TEST SUCCESS.");
                                    break;

                                case "2":
                                    WriteLine("About: Test wanted level up increases player wanted level by 1 point. (Cannot be above 5)");
                                    Thread.Sleep(2000);
                                    PLAYER.WantedLevelUp(1);
                                    WriteLine($"The PLAYERS wanted level is now {PLAYER.WANTED_LEVEL}");
                                    WriteLine("TEST SUCCESS.");
                                    break;

                                case "3":
                                    WriteLine("About: Test wanted level up decreases player wanted level by 1 point. (Cannot be below 0)");
                                    Thread.Sleep(2000);
                                    PLAYER.WantedLevelDown(1);
                                    WriteLine($"The PLAYERS wanted level is now {PLAYER.WANTED_LEVEL}");
                                    WriteLine("TEST SUCCESS.");
                                    break;

                                default:
                                    WriteLine("OUT OF RANGE");
                                    break;
                            }
                            break; //end of PLAYER menu


                        default:
                            WriteLine("OUT OF RANGE");
                            break; //end of MAIN MENU
                    }

                }
                else
                {
                    WriteLine("Login failed. Enter the correct password.");
                    adminValidated = false;
                }
            }
        }

        public static void RunAnotherTest(Player PLAYER)
        {
            WriteLine("Do you want to run another unit test ? Press 'Y' for yes or 'N' for no: ");
            Write(">> ");
            string rawResponse = ReadLine();
            string response = rawResponse.ToUpper();
            WriteLine(response);
            while (response != "Y" && response != "N")
            {
                WriteLine("Please respond with 'Y' or 'N' only..");
                rawResponse = ReadLine();
                response = rawResponse.ToUpper();

                //logic for PLAYER response 
                if (response == "Y")
                {
                    MainMenu(PLAYER);
                    break;
                }
                else
                {
                    Environment.Exit(0);
                    break;
                }
            }
        }
    }
}