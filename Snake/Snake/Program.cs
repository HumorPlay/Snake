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

            Console.SetBufferSize( 120, 30);

            HorizontalLine topLine = new HorizontalLine(0, 119, 0, '#');
            HorizontalLine bottomLine = new HorizontalLine(0, 119, 27, '#');
            topLine.Draw();
            bottomLine.Draw();



            Console.ReadLine();

        }
    }
}
