using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;
        public Walls (int mapWidht, int mapHeight)
        {
            wallList = new List<Figure>();

            // Отрисовка рамочки
            HorisontalLine topLine = new HorisontalLine(0, mapWidht-2, 0, '+');
            HorisontalLine bottonLine = new HorisontalLine(0, mapWidht-2, mapHeight-1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight-1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight-1, mapWidht-2, '+');
            wallList.Add(topLine);
            wallList.Add(bottonLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }
        internal bool IsHit (Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach (var wall in wallList)
            { 
                wall.Draw();
            }
        }
    }
}
