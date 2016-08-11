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
            Console.SetBufferSize(80, 25);

            // Отрисовка рамочки
            HorisontalLine topLine = new HorisontalLine(0, 78, 0, '+');
            HorisontalLine bottonLine = new HorisontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            topLine.Drow();
            bottonLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            //отрисовка точек

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
        }
    }
}
