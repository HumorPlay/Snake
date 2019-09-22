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

            Console.SetBufferSize(120, 30);

            HorizontalLine topLine = new HorizontalLine(0, 119, 0, '#');
            HorizontalLine bottomLine = new HorizontalLine(0, 119, 27, '#');
            topLine.Draw();
            bottomLine.Draw();
            VerticalLines leftBoarder = new VerticalLines(0, 27, 0, '#');
            VerticalLines rightBoarder = new VerticalLines(0, 27, 119, '#');
            leftBoarder.Draw();
            rightBoarder.Draw();

            Point p = new Point { x = 60, y = 14, sym = '*' };
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            

            Console.ReadLine();

        }
    }
}
