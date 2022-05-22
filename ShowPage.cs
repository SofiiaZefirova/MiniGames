using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGames
{
    public static class ShowPage
    {
        public static void BunnySendMessage(string message, int x = 35, int y = 7, string message2 = " ")
        {
            Console.ResetColor();
            Console.SetCursorPosition(0, y);
            Console.WriteLine(new string(' ', 130));
            Console.SetCursorPosition(x, y);
            Console.Write($" (\\___/)  /_   ");
            Console.WriteLine(message);
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine(new string(' ', 130));
            Console.SetCursorPosition(x, y + 1);
            Console.Write("(= '.' =)      ");
            Console.WriteLine(message2);
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine(" ( )_( )");
        }
        public static void UserInputBunny(int x = 90, int y = 29)
        {
            Console.SetCursorPosition(100, y-1);
            Console.WriteLine(new string(' ', 50));
            Console.SetCursorPosition(x, y);
            Console.Write($"________\\  (\\___/)");
            Console.SetCursorPosition(x+10, y + 1);
            Console.WriteLine("(= '.' =)");
            Console.SetCursorPosition(x+11, y + 2);
            Console.WriteLine("( )_( )");
            Console.SetCursorPosition(x+3, y-1);
        }
        public static void MainMenu()
        {
            Console.Clear();
            Console.WindowWidth = 125;
            Console.WindowHeight = 35;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"   __        __   _                            _          _   _            __  __ _       _  ____
   \ \      / /__| | ___ ___  _ __ ___   ___  | |_ ___   | |_| |__   ___  |  \/  (_)_ __ (_)/ ___| __ _ _ __ ___   ___  ___
    \ \ /\ / / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \  | __| '_ \ / _ \ | |\/| | | '_ \| | |  _ / _` | '_ ` _ \ / _ \/ __|
     \ V  V /  __/ | (_| (_) | | | | | |  __/ | || (_) | | |_| | | |  __/ | |  | | | | | | | |_| | (_| | | | | | |  __/\__ \
      \_/\_/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/   \__|_| |_|\___| |_|  |_|_|_| |_|_|\____|\__,_|_| |_| |_|\___||___/
                            ");
            Console.ResetColor();
            BunnySendMessage(message: "Hello! Choose the game you want to play!", 40, 7);
            Console.SetCursorPosition(0, 10);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("  " + new string('-', 121));
            Console.ResetColor();
            Console.WriteLine(@"
                   __                 _                                                                __  
                  (_  |\ |  /\  |_/  |_    __ __ __ __ __ __ __ __ __ __ __ __ __ __ __ __ __ __ __  | _/ | 
                  __) | \| /--\ | \  |_                                                              | _) | 
                                                                                                    
                   __      _  __  __   ___     _                  _   _  _                             _    
                  /__ | | |_ (_  (_     | |_| |_   |\ | | | |\/| |_) |_ |_) __ __ __ __ __ __ __ __  |  ) |  
                  \_| |_| |_ __) __)    | | | |_   | \| |_| |  | |_) |_ | \                          | /_ |  
                                                                                                         
                   _    ___ ___        ___      ___    __            _  __                                
                  |_ \/  |   |    |\/|  |  |\ |  |    /__  /\  |\/| |_ (_    __ __ __ __ __ __ __ __ | /| | 
                  |_ /\ _|_  |    |  | _|_ | \| _|_   \_| /--\ |  | |_ __)                           |  | | 
                                                                                                          
                    ");
            UserInputBunny();
        }
        public static void GuessTheNumberPage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
                             ____                    _____ _          _   _                 _               
                            / ___|_   _  ___  ___ __|_   _| |__   ___| \ | |_   _ _ __ ___ | |__   ___ _ __ 
                           | |  _| | | |/ _ \/ __/ __|| | | '_ \ / _ \  \| | | | | '_ ` _ \| '_ \ / _ \ '__|
                           | |_| | |_| |  __/\__ \__ \| | | | | |  __/ |\  | |_| | | | | | | |_) |  __/ |   
                            \____|\__,_|\___||___/___/|_| |_| |_|\___|_| \_|\__,_|_| |_| |_|_.__/ \___|_|                                                                                     
                                ");
            Console.ResetColor();
            BunnySendMessage(message: "in this game, you should guess the number in-between 0...100 range");
            Console.SetCursorPosition(0, 11);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("  " + new string('-', 122));
            Console.ResetColor();
            UserInputBunny();
        }
        public static void SnakePage()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
                 ____                 ____       _____             _                         ____                  ____
                / 0 0\               / 0 0\     /  ___|           | |                       / 0 0\                / 0 0\
                \  ~~~~              \  ~~~~    \ `--. _ __   __ _| | _____                 \  ~~~~               \  ~~~~
                 \  /                 \  /       `--. \ '_ \ / _` | |/ / _ \                 \  /                  \  /
       __________/ /        __________/ /       /\__/ / | | | (_| |   <  __/       __________/ /         __________/ /
    ~=:___________/      ~=:___________/        \____/|_| |_|\__,_|_|\_\___|    ~=:___________/       ~=:___________/                                             
                                                                ");
            Console.ResetColor();
            BunnySendMessage(message: "It's a 'Snake' game. I hope you know the rules.", 35, 9, message2: "Press any key to start the game!");
            Console.SetCursorPosition(0, 12);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("  " + new string('-', 122));
            Console.ResetColor();
            UserInputBunny(100, 30);
        }

        public static void YouWinPage()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 7);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"     
                                     ██╗   ██╗ ██████╗ ██╗   ██╗    ██╗    ██╗██╗███╗   ██╗██╗██╗██╗
                                     ╚██╗ ██╔╝██╔═══██╗██║   ██║    ██║    ██║██║████╗  ██║██║██║██║
                                      ╚████╔╝ ██║   ██║██║   ██║    ██║ █╗ ██║██║██╔██╗ ██║██║██║██║
                                       ╚██╔╝  ██║   ██║██║   ██║    ██║███╗██║██║██║╚██╗██║╚═╝╚═╝╚═╝
                                        ██║   ╚██████╔╝╚██████╔╝    ╚███╔███╔╝██║██║ ╚████║██╗██╗██╗
                                        ╚═╝    ╚═════╝  ╚═════╝      ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝╚═╝╚═╝
                                                                 
                                ");
            BunnySendMessage(message: "Thank you for playing the game. Press any key to return to the main menu.", 24, 16);
            Console.ResetColor();
        }

        public static void GoodByePage()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 9);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"
                                 ██████╗  ██████╗  ██████╗ ██████╗     ██████╗ ██╗   ██╗███████╗██╗               
                                ██╔════╝ ██╔═══██╗██╔═══██╗██╔══██╗    ██╔══██╗╚██╗ ██╔╝██╔════╝██║               
                                ██║  ███╗██║   ██║██║   ██║██║  ██║    ██████╔╝ ╚████╔╝ █████╗  ██║               
                                ██║   ██║██║   ██║██║   ██║██║  ██║    ██╔══██╗  ╚██╔╝  ██╔══╝  ╚═╝               
                                ╚██████╔╝╚██████╔╝╚██████╔╝██████╔╝    ██████╔╝   ██║   ███████╗██╗               
                                 ╚═════╝  ╚═════╝  ╚═════╝ ╚═════╝     ╚═════╝    ╚═╝   ╚══════╝╚═╝               
                                                                                                    
                  ███████╗███████╗███████╗    ██╗   ██╗ ██████╗ ██╗   ██╗    ███████╗ ██████╗  ██████╗ ███╗   ██╗██╗
                  ██╔════╝██╔════╝██╔════╝    ╚██╗ ██╔╝██╔═══██╗██║   ██║    ██╔════╝██╔═══██╗██╔═══██╗████╗  ██║██║
                  ███████╗█████╗  █████╗       ╚████╔╝ ██║   ██║██║   ██║    ███████╗██║   ██║██║   ██║██╔██╗ ██║██║
                  ╚════██║██╔══╝  ██╔══╝        ╚██╔╝  ██║   ██║██║   ██║    ╚════██║██║   ██║██║   ██║██║╚██╗██║╚═╝
                  ███████║███████╗███████╗       ██║   ╚██████╔╝╚██████╔╝    ███████║╚██████╔╝╚██████╔╝██║ ╚████║██╗
                  ╚══════╝╚══════╝╚══════╝       ╚═╝    ╚═════╝  ╚═════╝     ╚══════╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═══╝╚═╝
                                                                                                    
                        ");
            Console.ResetColor();
        }

    }
}
