using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Borders
    {
        List<Figure> wallList;
        private HorizontalLine topLine;
        private HorizontalLine bottomLine;
        private VerticalLines leftBoarder;
        private VerticalLines rightBoarder;


        public Borders(int _Height, int _Width)
        {
            wallList = new List<Figure>();

            topLine = new HorizontalLine(0, _Width - 2, 0, '+');
            bottomLine = new HorizontalLine(0, _Width - 2, _Height - 1, '+');
            leftBoarder = new VerticalLines(0, _Height - 1, 0, '+');
            rightBoarder = new VerticalLines(0, _Height - 1, _Width - 2, '+');
            wallList.Add(topLine);
            wallList.Add(bottomLine);
            wallList.Add(leftBoarder);
            wallList.Add(rightBoarder);
        }

        public void Draw()
        {
            foreach (Figure i in wallList)
                i.Draw();
        }
        public bool IsHit(Figure figure)
        {
            foreach (Figure i in wallList)
            {
                if (i.IsHit(figure))
                    return true;
            }
            return false;
        }

    }
}
