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

        public virtual void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public Point()
        {

        }
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.DOWN)
                y = y - offset;
            if (direction == Direction.LEFT)
                x = x - offset;
            if (direction == Direction.RIGHT)
                x = x + offset;
            if (direction == Direction.UP)
                y = y + offset;
        }

    }

}

