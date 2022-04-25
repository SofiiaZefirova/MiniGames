using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGames
{
    class GuessTheNumberGame
    {
        Random randomizer = new Random();
        private int winNum;
        private bool winCase;
        private int userAttemptNumber = 0;

        public void RunGame()
        {
            ResetSettings();
            //Main game loop
            do
            {
                userAttempt(ref userAttemptNumber);

                if(userAttemptNumber > 100 || userAttemptNumber < 0)
                {
                    ShowPage.BunnySendMessage(message: "Your number is out of the range 0...100. Try again.");
                    ShowPage.UserInputBunny();
                    continue;
                }
                else if(userAttemptNumber > winNum)
                {
                    ShowPage.BunnySendMessage(message: $"{userAttemptNumber} is too high! Guess lower...");
                    ShowPage.UserInputBunny();
                    Console.ResetColor();
                }
                else if (userAttemptNumber < winNum)
                {
                    ShowPage.BunnySendMessage(message: $"{userAttemptNumber} is too low! Guess higher...");
                    ShowPage.UserInputBunny();
                    Console.ResetColor();
                }
                else if (userAttemptNumber == winNum)
                {
                    winCase = true;
                }
            } while (winCase == false);

            //End of the game
            ShowPage.YouWinPage();
            ShowPage.UserInputBunny();
            Console.ReadKey();
        }
        //Method for handling an attempt to guess a number
        private void userAttempt(ref int userAttemptNumber)
        {
            if (!int.TryParse(Console.ReadLine(), out userAttemptNumber))
            {
                ShowPage.BunnySendMessage(message: "You didn't enter a number. Try again.");
                userAttempt(ref userAttemptNumber);
            }
        }
        //Method for rsetting main fields
        private void ResetSettings()
        {
           winCase = false;
           winNum = randomizer.Next(0, 100);
        }

    }
}
