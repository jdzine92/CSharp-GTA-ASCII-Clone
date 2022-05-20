using System;
using static System.Console;

namespace JordansGTAClone
{
    class PlayCards
    {
        //Declare global variables for Start()
        //Outside of function scope so that they are not reset with each function call.
        static int roundCount = 1; //start at round 1 
        static int correctGuesses = 0;
        static int guessedHigh = 0;
        static int guessedLow = 0;

        public static void Start(Player PLAYER)
        {
            bool gameplay = true;
            while (gameplay)
            {
                //check max rounds playable is not exceeded before playing. (Max 4 rounds per session)
                if (roundCount == Limits.MAX_PLAY_CARDS_ROUNDS)
                {
                    //END GAME if at max rounds
                    gameplay = false;
                    Display.TextColour("narratorWriteLine", "You have played enough rounds with Tony today. Please come back another time.");
                    Thread.Sleep(2000);
                    break;
                }

                //check PLAYER has 5 or more credits to play the first /another round
                if (PLAYER.CREDITS < 5)
                {
                    //END GAME if credits too low
                    gameplay = false;
                    Display.TextColour("narratorWriteLine", "You do not have enough credits to play with Tony. Earn some credits and come back another time.");
                    Thread.Sleep(2000);
                    break;
                }

                //display game rules to player
                Display.TextColour("tony", "Tony: We're playing a guessing game. I draw the card, you guess the number.");
                Thread.Sleep(4000);
                Display.TextColour("tony", "Respond with 1 for Ace, 2-10 for the number cards, 11 for Jack, 12 for Queen or 13 for King.");
                Thread.Sleep(5500);
                Display.TextColour("tony", "If you win I pay you 50 credits. If you lose you pay me 5 credits. Good luck!");
                Thread.Sleep(5000);

                //generate Tony's card (rand 1-13)
                Random rnd = new Random();
                int randomNum = rnd.Next(1, 14);

                //display main game
                WriteLine($"Round Number: {roundCount}");
                Thread.Sleep(2000);
                Display.TextColour("tony", "Tony: Card drawn. Enter your guess now:");
                Display.TextColour("yellow >>", ">> ");
        
                string playerGuess = ReadLine();
                //try parse playerGuess to int
                bool validated = int.TryParse(playerGuess, out int guess);
                //if playerGuess out of range display tony warning
                if (guess < 1 || guess > 13)
                {
                    Display.TextColour("tony", "Tony: I'm not sure you understood the rules, lets try again ...");
                    Thread.Sleep(2000);
                }
                //else continue with game if 1-13
                else 
                {
                    if (validated)
                    {
                        //increment round count
                        roundCount++;
                        //show players card and tonys card
                        Thread.Sleep(1000);
                        WriteLine($"You guessed: {guess}");
                        Display.DisplayCard(guess);
                        Thread.Sleep(1000);
                        WriteLine($"Tony draws: {randomNum}");
                        Display.DisplayCard(randomNum);
                        Thread.Sleep(1000);
                        //Logic to compare PLAYER guess (guess) against Tony's card (randomNum)
                        if (guess == randomNum)
                        {
                            correctGuesses++;
                            Display.TextColour("tony", "Tony: Damn! You guessed correctly. You win 50 credits. \n");
                            Thread.Sleep(2000);
                            PLAYER.CREDITS += 50;
                        }
                        if (guess > randomNum)
                        {
                            guessedHigh++;
                            PLAYER.CREDITS -= 5;
                            Display.TextColour("tony", "Tony: You guessed too high, you lose this one. You owe me 5 credits. \n");
                            Thread.Sleep(2000);
                        }
                        if (guess < randomNum)
                        {
                            guessedLow++;
                            PLAYER.CREDITS -= 5;
                            Display.TextColour("tony", "Tony: You guessed too low, you lose this one. You owe me 5 credits. \n");
                            Thread.Sleep(2000);
                        }

                        //calculate credits won (50 per round won)
                        int creditsWon = correctGuesses * 50;
                        //calculate credits lost (5 per round lost)
                        int creditsLost = (guessedLow * 5) + (guessedHigh * 5);

                        //display game stats to player
                        Display.TextColour("cards-stats", $"----GAME STATS---- \n Correct Guesses: {correctGuesses} \n Guessed High: {guessedHigh} \n Guessed Low: {guessedLow} \n Credits Won: {creditsWon} \n Credits Lost: {creditsLost} \n Credits Remaining: {PLAYER.CREDITS} \n");
                        Thread.Sleep(4000);

                        //Give PLAYER choice to play another round
                        bool playAgain = false;
                        while (!playAgain)
                        {
                            Display.TextColour("tony", "Tony: Want to play me again? Press 'Y' for yes or 'N' for no..");
                            string rawResponse = ReadLine();
                            string response = rawResponse.ToUpper();
                            if (response == "Y")
                            {   
                                playAgain = true;
                                gameplay = true;
                                Start(PLAYER);
                                break;
                            }
                            else if (response == "N")
                            {
                                playAgain = false;
                                gameplay = false;
                                Display.TextColour("tony", "Tony: Maybe another time eh ?");
                                Thread.Sleep(2000);
                                break;
                            }
                            else
                            {
                                playAgain = false;
                                Display.TextColour("tony", "Tony: I'm looking for a yes (Y) or a no (N)..");
                                Thread.Sleep(2000);
                            }
                        }
                    }
                }  
            }
        }
    }
}