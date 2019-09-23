using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLines : Figure
    {

        public VerticalLines(int start, int end, int column, char sym)
        {
            pList = new List<Point>();

            for (int i = 0; i < end; i++)
            {
                Point a = new Point();
                a.x = column;
                a.y = i;
                a.sym = sym;
                pList.Add(a);
            }
        }
    }
}
