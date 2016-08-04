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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(11, 11, '^');
            Point p4 = new Point(14, 15, '@');

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            List<char> charList = new List<char>();
            charList.Add('@');
            charList.Add('&');
            charList.Add('^');

            char sym0 = charList[0];
            char sym1 = charList[1];
            char sym2 = charList[2];

            Console.WriteLine(sym0);
            Console.WriteLine(sym1);
            Console.WriteLine(sym2);



            Console.ReadLine();
        }
    }
}
