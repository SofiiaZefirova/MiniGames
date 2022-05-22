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
            SnakeGame = 3,
            //TODO: packman
            //PacMan = 4
        }
        static void Main()
        {
            Console.Title = "MiniGames";
            bool stopgame = false;

            while (stopgame == false)
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
                            GuessTheNumberGame.RunGame();
                            break;
                        case userChoiseMainMenu.SnakeGame:
                            ShowPage.SnakePage();
                            SnakeGame.RunGame();
                            break;
                        //TODO: packman
                        //case userChoiseMainMenu.PacMan:

                        //    break;
                    }
                }
            }
        }
    }
}
