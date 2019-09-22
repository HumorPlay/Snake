using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        
        public Snake(Point start, int length, Direction direction)
        {
            pList = new List<Point>();
            pList.Add(start);
            for(int i = 1; i < length; i++)
            {
                Point x = new Point(start);
                x.Move(i, direction);
                pList.Add(x);

            }
        }
    } 
}
