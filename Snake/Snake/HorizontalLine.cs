using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Point
    {

        List<Point> pList;

        public HorizontalLine(int start, int end, int height, char symbol)
        {
            pList = new List<Point>();

            for (int i = start; i <= end; i++)
            {
                Point p = new Point();
                p.x = i;
                p.y = height;
                p.sym = symbol;
                pList.Add(p);

            }
        }

        public override void Draw()
        {
            foreach (Point p in pList)
            p.Draw();
        }



    }

}

