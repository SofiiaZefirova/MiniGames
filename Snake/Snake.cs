using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGames
{
    public class Snake
    {
        public Pixel Head { get; private set; }
        public Queue<Pixel> Body { get; } = new Queue<Pixel>();

        private readonly ConsoleColor _headColor;
        private readonly ConsoleColor _bodyColor;

        public Snake(int initialX, int initialY, ConsoleColor headColor, ConsoleColor bodyColor, int bodyLenght = 3)
        {
            _headColor = headColor;
            _bodyColor = bodyColor;
            Head = new Pixel(initialX, initialY, headColor);
            for (int i = bodyLenght; i >= 0; i--)
            {
                Body.Enqueue(new Pixel(Head.X - i - 1, initialY, bodyColor));
            }
            
        }

        public void Move(Direction direction, bool eat = false)
        {
            Body.Enqueue(new Pixel(Head.X, Head.Y, _bodyColor));
            if (!eat)
            {
                Pixel tail = Body.Dequeue();
                tail.Clear();
            }

           switch (direction)
           {
               case Direction.Up:
                    Head = new Pixel(Head.X, Head.Y - 1, _headColor);
                    break;
               case Direction.Down:
                    Head = new Pixel(Head.X, Head.Y + 1, _headColor);
                    break;
               case Direction.Left:
                    Head = new Pixel(Head.X - 1, Head.Y, _headColor);
                    break;
                case Direction.Right:
                    Head = new Pixel(Head.X + 1, Head.Y, _headColor);                   
                    break;
            }
            Draw();
        }
        
        public void Draw()
        {
            Head.Draw();
            foreach(Pixel pixel in Body)
            {
                pixel.Draw();
            }
        }
        public void Clear()
        {
            Head.Clear();
            foreach (Pixel pixel in Body)
            {
                pixel.Clear();
            }
        }
    }
}
