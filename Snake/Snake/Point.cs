using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {

        public int x { get; set; }
        public int y { get; set; }
        public char sym { get; set; }

        public Point()
        {

        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public Point(int _x, int _y, char _sym)
        {
            this.x = _x;
            this.y = _y;
            this.sym = _sym;

        }


        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.DOWN)
                y = y + offset;
            if (direction == Direction.LEFT)
                x = x - offset;
            if (direction == Direction.RIGHT)
                x = x + offset;
            if (direction == Direction.UP)
                y = y - offset;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public bool IsHit(Point _p)
        {
            return this.x == _p.x && this.y == _p.y;
        }

    }

}

