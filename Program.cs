using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGames
{

    class Program
    {
        public static void userAttempt(ref int userAttemptNumber)
        {
            if (!int.TryParse(Console.ReadLine(), out userAttemptNumber))
            {
                Console.WriteLine("You didn't enter a number in-between 0...100. Try again.");
                userAttempt(ref userAttemptNumber);
            }
        }
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            int winNum = randomizer.Next(0, 100);
            bool winCase = false;
            int userAttemptNumber = 0;
            Console.WriteLine("Gues the number in-between 0...100!");

            do
            {
                userAttempt(ref userAttemptNumber);

                if (userAttemptNumber > winNum)
                {
                    Console.WriteLine("Too high! Guess lower...");
                }
                else if (userAttemptNumber < winNum)
                {
                    Console.WriteLine("Too low! Guess higher...");
                }
                else if (userAttemptNumber == winNum)
                {
                    Console.WriteLine("YOU WIN!!!");
                    winCase = true;
                }
            } while (winCase == false);

            Console.WriteLine("Thank you for playing the game.");
            Console.WriteLine("Press any key to finish...");
            Console.ReadKey();
        }
    }
}
