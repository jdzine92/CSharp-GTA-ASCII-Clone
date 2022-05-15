using System;
using static System.Console;

namespace JordansGTAClone
{
    class PlayCards
    {
        //Declare variables for Start()
        //Outside of function scope so that they are not reset with each function call.
        static int roundCount = 0;
        static int correctGuesses = 0;
        static int guessedHigh = 0;
        static int guessedLow = 0;

        public static void Start(Player PLAYER)
        {
            bool continuePlaying = true;
            while (continuePlaying)
            {
                //check max rounds playable is not exceeded before playing. (Max 4 rounds per session)
                if (roundCount == Limits.MAX_PLAY_CARDS_ROUNDS)
                {
                    continuePlaying = false;
                    Display.TextColour("narratorWriteLine", "You have played enough rounds with Tony today. Please come back another time.");
                    break;
                }

                //check PLAYER has 5 or more credits to play another round
                if (PLAYER.CREDITS < 5)
                {
                    continuePlaying = false;
                    Display.TextColour("narratorWriteLine", "You do not have enough credits to play with Tony. Earn some credits and come back another time.");
                    break;
                }

                //display game rules
                Display.TextColour("tony", "Tony: We're playing a guessing game. I draw the card, you guess the number.");
                Thread.Sleep(4000);
                Display.TextColour("tony", "Respond with 1 for Ace, 2-10 for the number cards, 11 for Jack, 12 for Queen or 13 for King.");
                Thread.Sleep(5500);
                Display.TextColour("tony", "If you win I pay you 50 credits. If you lose you pay me 5 credits. Good luck!");
                Thread.Sleep(5000);

                //increment round count
                roundCount++;
                //generate Tony's card (rand 1-13)
                Random rnd = new Random();
                int randomNum = rnd.Next(1, 14);

                //MAIN CARDS GAME
                WriteLine($"Round Number: {roundCount}");
                Thread.Sleep(2000);
                Display.TextColour("tony", "Tony: Card drawn. Enter your guess now:");
                Display.TextColour("yellow >>", ">> ");
                //convert to int32 to evaluate against randomNum
                int guess = Convert.ToInt32(ReadLine());
                Thread.Sleep(1000);
                WriteLine($"Tony draws: {randomNum}");
                Thread.Sleep(1000);
                WriteLine($"You guessed: {guess}");
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
                WriteLine($"GAME STATS \n Correct Guesses: {correctGuesses} \n Guessed High: {guessedHigh} \n Guessed Low: {guessedLow} \n Credits Won: {creditsWon} \n Credits Lost: {creditsLost} \n Credits Remaining: {PLAYER.CREDITS} \n");
                Thread.Sleep(4000);

                //Give PLAYER choice to play another round
                Display.TextColour("tony", "Tony: Want to play me again? Press 'Y' for yes or 'N' for no..");
                string rawResponse = ReadLine();
                string response = rawResponse.ToUpper();
                if (response == "Y")
                {
                    continuePlaying = true;
                    Start(PLAYER);
                    break;
                }
                else if (response == "N")
                {
                    continuePlaying = false;
                    Thread.Sleep(1000);
                    Display.TextColour("tony", "Tony: Maybe another time eh ?");
                    break;
                }
                else
                {
                    WriteLine("You have pressed an invalid key, please try again.");
                }
            }
        }
    }
}
