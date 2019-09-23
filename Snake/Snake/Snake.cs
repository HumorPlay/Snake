using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {

        Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            pList.Add(tail);
            for (int i = 1; i < length; i++)
            {
                Point x = new Point(tail);
                x.Move(i, direction);
                pList.Add(x);

            }
        }
        public void Move()
        {
            Point tail = pList.First();
            Point currentHead = pList.Last();
            Point head = GetNextPoint();

           
            
                pList.Remove(tail);
                pList.Add(head);
                tail.Clear();
                head.Draw();

        }

        private Point GetNextPoint()
        {

            Point lastP = new Point(pList.Last());
            lastP.Move(1, direction);
            return lastP;
        }
        public void HadleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;

        }
        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                food.Draw();
                pList.Add(food);
                return true;
            }
            else
            return false;
        }

        public bool IsHitTail()
        {
            Point head = pList.Last();
            for (int i=0; i < pList.Count -2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }
    }
}
