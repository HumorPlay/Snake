using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            int DispHeight = 20;
            int DispWidth = 80;
            //Console.SetBufferSize(DispWidth, DispHeight);
            Console.CursorVisible = false;

            Borders board = new Borders(DispHeight, DispWidth);
            board.Draw();


            Point p = new Point { x = 60, y = 14, sym = '*' };
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(DispWidth, DispHeight, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                board.Draw();

                if (board.IsHit(snake) || snake.IsHitTail())
                    break;

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                    snake.Move();

                System.Threading.Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HadleKey(key.Key);
                }
            }
        }
    }
}
