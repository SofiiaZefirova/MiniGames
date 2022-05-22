using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MiniGames
{
    public class SnakeGame
    {
        static private readonly int MapWidth= 60;
        static private readonly int MapWidthGap = 30;
        static private readonly int MapHeight = 21;
        static private readonly int MapHeightGap = 13;
        static private readonly int GameSpeed = 100;
        static private readonly ConsoleColor BorderColor = ConsoleColor.DarkGray;
        static private readonly ConsoleColor HeadColor = ConsoleColor.Green;
        static private readonly ConsoleColor BodyColor = ConsoleColor.Gray;
        static private readonly ConsoleColor FoodColor = ConsoleColor.DarkRed;
        static private int score = 0;
        static private int lagMs = 0;
        static Random randomizer = new Random();
        static public void RunGame()
        {            
            DrawBorder();

            Direction currentMovement = Direction.Right;
            Snake snake = new Snake(62, 23, HeadColor, BodyColor);
            snake.Draw();

            Console.ReadKey();
            ShowPage.BunnySendMessage(message: $"Let's play!", 35, 9);

            Pixel food = GenFood(snake);
            food.Draw();

            Stopwatch stopwatch = new Stopwatch();

            while (true)
            {
                stopwatch.Restart();
                Direction oldMovement = currentMovement;

                while (stopwatch.ElapsedMilliseconds <= GameSpeed - lagMs)
                {
                    if(currentMovement == oldMovement)
                    { 
                        currentMovement = ReadMovement(currentMovement);
                    }
                }
                stopwatch.Restart();

                if (snake.Head.X == food.X && snake.Head.Y == food.Y)
                {
                    snake.Move(currentMovement, true);
                    food = GenFood(snake);
                    food.Draw();

                    score++;
                    if (score == 1)
                    {
                        ShowPage.BunnySendMessage(message: $"Way to go! Your score is: {score} point.", 35, 9);
                    }
                    else
                    {
                        ShowPage.BunnySendMessage(message: $"Way to go! Your score is: {score} points.", 35, 9);
                    }
 
                    Task.Run(() => Console.Beep(1500, 150));
                }
                else
                {
                    snake.Move(currentMovement);
                }

                if (snake.Head.X == MapWidthGap
                    || snake.Head.X == MapWidthGap + MapWidth
                    || snake.Head.Y == MapHeightGap
                    || snake.Head.Y == MapHeightGap + MapHeight
                    || snake.Body.Any(Pixel => Pixel.X == snake.Head.X && Pixel.Y == snake.Head.Y))
                {
                    break;
                }
                lagMs = (int)stopwatch.ElapsedMilliseconds;
            }
            Task.Run(() => Console.Beep(200, 300));
            Console.SetCursorPosition(80,35);
            ShowPage.BunnySendMessage(message: $"Game over. Your score is {score} points.", 35, 9, message2: "Thank you for playing the game. Press any key to return to the main menu.");
            ShowPage.UserInputBunny(100, 30);
            //Delay
            Console.ReadLine();
        }
        static void DrawBorder()
        {
            Console.ForegroundColor = BorderColor;
            for (int i = MapWidthGap; i < MapWidthGap + MapWidth + 1; i++)
            {
                new Pixel(i, MapHeightGap, BorderColor).Draw();
                new Pixel(i, MapHeightGap + MapHeight, BorderColor).Draw();
            }
            for (int i = MapHeightGap; i < MapHeight + MapHeightGap + 1; i++)
            {
                new Pixel(MapWidthGap, i, BorderColor).Draw();
                new Pixel(MapWidthGap + MapWidth, i, BorderColor).Draw();
            }
            Console.ResetColor();
        }
         static Pixel GenFood(Snake snake)
        {
            Pixel food;

            do
            {
                food = new Pixel(randomizer.Next(MapWidthGap + 1, MapWidthGap + MapWidth - 1), randomizer.Next(MapHeightGap + 1, MapHeight + MapHeightGap - 1), FoodColor);
            } while (snake.Head.X == food.X && snake.Head.Y == food.Y ||
                     snake.Body.Any(b => b.X == food.X && b.Y == food.Y));

            return food;
        }
        static Direction ReadMovement(Direction currentdirection)
        {
            if (!Console.KeyAvailable)
            {
                return currentdirection;
            }
            ConsoleKey key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (currentdirection != Direction.Down)
                    {
                        currentdirection = Direction.Up;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (currentdirection != Direction.Up)
                    {
                        currentdirection = Direction.Down;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (currentdirection != Direction.Left)
                    {
                        currentdirection = Direction.Right;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (currentdirection != Direction.Right)
                    {
                        currentdirection = Direction.Left;
                    }
                    break;
            }
            return currentdirection;
        }

    }
}
