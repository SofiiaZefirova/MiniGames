using System;
using System.Threading;

namespace MiniGames
{
    class Program
    {
        enum userChoiseMainMenu
        {
            ExitMiniGames = 1,
            GuessTheNumberGame = 2,
            //SnakeGame = 3
        }
        static void Main(string[] args)
        {
            bool stopgame = false;

            while(stopgame == false)
            {
                ShowPage.MainMenu();

                int userChoise;
                if (int.TryParse(Console.ReadLine(), out userChoise))
                {

                    switch ((userChoiseMainMenu)userChoise)
                    {
                        case userChoiseMainMenu.ExitMiniGames:
                            ShowPage.GoodByePage();
                            Thread.Sleep(2000);
                            stopgame = true;
                            break;

                        case userChoiseMainMenu.GuessTheNumberGame:
                            ShowPage.GuessTheNumberPage();
                            GuessTheNumberGame game = new GuessTheNumberGame();
                            game.RunGame();
                            break;
                        //case userChoiseMainMenu.SnakeGame:

                        //    break;
                    }
                }
            }
        }
    }
}
