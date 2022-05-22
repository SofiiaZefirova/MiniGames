using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGames
{
    public class Pixel
    {
        //TODO: pixelchar options
        private readonly char PixelChar = '■';
        //private const char PixelChar2 = '█';
        //private const char PixelChar3 = '*';
        public int X { get; set; }
        public int Y { get; set; }

        public ConsoleColor Color { get; }

        public Pixel(int x, int y, ConsoleColor color)

        {
            X = x;
            Y = y;
            Color = color;
        }

        public void Draw()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(X, Y);
            Console.Write(PixelChar);
        }
        public void Clear()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(' ');
        }

    }
}
